using Microsoft.AspNetCore.Identity;

namespace JediOrderApi.Repository
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
