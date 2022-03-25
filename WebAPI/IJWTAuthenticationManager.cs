

namespace WebAPI
{
    public interface IJWTAuthenticationManager
    {
       string Authenticate(string mail, string sifre);
    }
}
