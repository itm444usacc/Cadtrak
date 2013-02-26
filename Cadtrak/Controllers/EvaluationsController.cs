using System.Web.Mvc;

namespace Cadtrak.Controllers
{
    public class EvaluationsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Evaluations Contoller.";

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
