using System.Web.Mvc;

namespace Cadtrak.Controllers
{
    public class TrainingController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Training Contoller.";

            return View("Index");
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }
    }
}
