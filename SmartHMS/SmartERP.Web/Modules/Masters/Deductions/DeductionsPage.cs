using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Masters.Pages
{

    [PageAuthorize(typeof(DeductionsRow))]
    public class DeductionsController : Controller
    {
        [Route("Masters/Deductions")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Deductions/DeductionsIndex.cshtml");
        }
    }
}