
using Rest_API_Clean_Architecture.Application.Common.Interfaces.Services;

namespace Rest_API_Clean_Architecture.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
