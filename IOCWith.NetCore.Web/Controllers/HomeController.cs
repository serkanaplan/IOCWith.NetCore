using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IOCWith.NetCore.Web.Models;

namespace IOCWith.NetCore.Web.Controllers;

// public class HomeController(ISingletonDateService singletonDateService) : Controller
// public class HomeController(IScoppedDateService scopedDateService) : Controller
public class HomeController(ITransientDateservice transientDateservice) : Controller
{
    // private readonly ISingletonDateService _singletonDateService = singletonDateService;
    // private readonly IScoppedDateService _scopedDateService = scopedDateService;
    private readonly ITransientDateservice _transientDateservice = transientDateservice;


    // hem constructordan hem de metod üzerinden enjekte etme işlemini gerçekleştirebiliriz. asp.net core default olarak IOC Conteyner sayesinde hem constructor hem de metod üzerinden enjekte edilen sınıflardan otomatik nesne örneği oluşturur
    // public IActionResult Index([FromServices] ISingletonDateService singletonDateService2)
    // public IActionResult Index([FromServices] IScoppedDateService scopedDateService2)
    public IActionResult Index([FromServices] ITransientDateservice transientDateservice2)
    {
        // ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
        // ViewBag.time2 = singletonDateService2.GetDateTime.TimeOfDay.ToString();
        // ViewBag.time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
        // ViewBag.time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();
        ViewBag.time1 = _transientDateservice.GetDateTime.TimeOfDay.ToString();
        ViewBag.time2 = transientDateservice2.GetDateTime.TimeOfDay.ToString();
        return View();
    }


    public IActionResult Privacy() => View();


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
