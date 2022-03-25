using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicisController : ControllerBase
    {
        IKullaniciService _kullaniciService;
        IJWTAuthenticationManager _jWTAuthenticationManager;
        public KullanicisController(IKullaniciService kullaniciService, IJWTAuthenticationManager jWTAuthenticationManager)
        {
            _kullaniciService = kullaniciService;
            _jWTAuthenticationManager = jWTAuthenticationManager;
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Kullanici kullanici)
        {
            var token = _jWTAuthenticationManager.Authenticate(kullanici.Mail, kullanici.Sifre);
            if (token == null) return Unauthorized();
            return Ok(token);
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kullaniciService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _kullaniciService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Kullanici kullanici)
        {
            var result = _kullaniciService.Add(kullanici);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Kullanici kullanici)
        {
            var result = _kullaniciService.Delete(kullanici);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Kullanici kullanici)
        {
            var result = _kullaniciService.Update(kullanici);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
