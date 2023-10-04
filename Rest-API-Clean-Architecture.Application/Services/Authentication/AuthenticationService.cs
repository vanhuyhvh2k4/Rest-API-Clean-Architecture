
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Authentication;

namespace Rest_API_Clean_Architecture.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // Check if already exits

            // Create new user

            // Create jwt token
            Guid userId = Guid.NewGuid();

            string token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
        }
    }
}
