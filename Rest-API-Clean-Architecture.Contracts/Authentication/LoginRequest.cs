
namespace Rest_API_Clean_Architecture.Contracts.Authentication
{
    public record LoginRequest(
       string Email,
       string Password
   );
}
