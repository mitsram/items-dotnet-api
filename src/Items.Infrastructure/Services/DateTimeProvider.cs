using Items.Application.Common.Interfaces.Services;

namespace Items.Infrastructure.Services;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}