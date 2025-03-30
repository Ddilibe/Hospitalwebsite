using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Masters.Pages
{

    [PageAuthorize(typeof(IncomesRow))]
    public class IncomesController : Controller
    {
        [Route("Masters/Incomes")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Incomes/IncomesIndex.cshtml");
        }
    }
}