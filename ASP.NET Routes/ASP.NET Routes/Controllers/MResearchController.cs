using System.Web.Mvc;

namespace ASP.NET_Routes.Controllers
{
    public class MResearchController : Controller
    {
        [HttpGet]
        public ActionResult M01(int? id)
        {
            return View();
        }
        
        public ActionResult M02(int? id)
        {
            return View();
        }
        
        public ActionResult M03(int? id)
        {
            return View();
        }
        
        public ActionResult Mxx(int? id)
        {
            return View();
        }
    }
}