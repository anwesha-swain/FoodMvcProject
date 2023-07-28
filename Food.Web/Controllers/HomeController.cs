using Food.Data.Services;
using System.Web.Mvc;

namespace Food.Web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        public HomeController(IRestaurantData db)
        {
            //db = new InMemoryRestaurantData();
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}