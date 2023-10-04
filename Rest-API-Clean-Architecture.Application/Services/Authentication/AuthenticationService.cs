
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Authentication;
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Persistence;
using Rest_API_Clean_Architecture.Domain.Entities;

namespace Rest_API_Clean_Architecture.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Login(string email, string password)
        {
            // 1. Validate user exists
            if (_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new Exception("User with given email is not exists");       
            }
            // 2. Validate the password is correct
            if (user.Password != password)
            {
                throw new Exception("Invalid password");
            }
            // 3. Create Jwt token
            string token = _jwtTokenGenerator.GenerateToken(user);
            return new AuthenticationResult(
                user,
                token);
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // 1. Check if already exists
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new Exception("User with given email already exists");
            }
            // 2. Create new user
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };

            _userRepository.Add(user);
            // 3. Create jwt token
            string token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthenticationResult(
                user,
                token);
        }
    }
}
