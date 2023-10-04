
using Rest_API_Clean_Architecture.Domain.Entities;

namespace Rest_API_Clean_Architecture.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
