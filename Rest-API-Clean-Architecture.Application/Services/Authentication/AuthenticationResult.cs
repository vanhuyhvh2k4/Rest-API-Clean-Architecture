
using Rest_API_Clean_Architecture.Domain.Entities;

namespace Rest_API_Clean_Architecture.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}
