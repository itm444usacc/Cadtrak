using System.Web.Mvc;

namespace Cadtrak.Controllers
{
    public class AssignmentsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Assignments Contoller.";

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
