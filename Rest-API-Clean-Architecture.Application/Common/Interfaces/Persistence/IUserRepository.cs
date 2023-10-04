
using Rest_API_Clean_Architecture.Domain.Entities;

namespace Rest_API_Clean_Architecture.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);

        void Add(User user);
    }
}
