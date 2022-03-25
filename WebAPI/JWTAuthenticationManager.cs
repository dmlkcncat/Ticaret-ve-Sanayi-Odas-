using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    public class JWTAuthenticationManager : IJWTAuthenticationManager
    {
        KullaniciManager kullaniciManager;
        IKullaniciDal kullaniciDal;

        private readonly string key;

        public JWTAuthenticationManager(string key)
        {
            this.key = key;
            kullaniciDal = new EfKullaniciDal();
            kullaniciManager = new KullaniciManager(kullaniciDal);
        }
        public string Authenticate(string mail, string sifre)
        {
            List<Kullanici> kullanicilars = this.kullaniciManager.GetAll().Data;
            Kullanici kullanici = kullanicilars.Find(_kullanici => _kullanici.Mail == mail && _kullanici.Sifre == sifre);

            if (kullanici == null) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, mail)
                }),

                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
