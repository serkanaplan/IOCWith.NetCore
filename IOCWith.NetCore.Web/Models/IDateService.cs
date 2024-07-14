namespace IOCWith.NetCore.Web.Models;


public interface IDateService
{
    DateTime GetDateTime { get; }
}

public interface ISingletonDateService : IDateService { }

public interface IScoppedDateService : IDateService { }

public interface ITransientDateservice : IDateService { }