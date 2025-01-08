namespace API;
using API.Entities;
public interface ITokenService 
{
    Task<string> CreateToken(AppUser user);
}