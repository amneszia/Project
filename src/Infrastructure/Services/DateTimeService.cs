using Project.Application.Common.Interfaces;

namespace Project.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
