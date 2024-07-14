namespace IOCWith.NetCore.Web.Models;

public class DateService : ISingletonDateService, IScoppedDateService, ITransientDateservice
{
    private readonly ILogger<DateService> _logger;

    public DateService(ILogger<DateService> logger)
    {
        _logger = logger;

        _logger.LogWarning("DateService constructor'ına girdi.");
    }

    public DateTime GetDateTime { get; } = DateTime.Now;
}