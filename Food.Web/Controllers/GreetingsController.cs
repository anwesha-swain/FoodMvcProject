using Food.Web.Models;
using System.Configuration;
using System.Web.Mvc;

namespace Food.Web.Controllers
{
    public class GreetingsController : Controller
    {
        // GET: Greetings
        public ActionResult Index()
        {
            var model = new GreetingViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}