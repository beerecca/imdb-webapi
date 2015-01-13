using System.Web.Mvc;

namespace IMDB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}