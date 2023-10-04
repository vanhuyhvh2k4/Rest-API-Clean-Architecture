
namespace Rest_API_Clean_Architecture.Application.Services.Authentication
{
    public record AuthenticationResult(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}
