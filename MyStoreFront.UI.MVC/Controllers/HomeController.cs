using System.Web.Mvc;

namespace MyStoreFront.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Shop()
        {
            return View();
        }
    }
}
