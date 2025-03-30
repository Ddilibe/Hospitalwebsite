using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Payroll.Pages
{

    [PageAuthorize(typeof(PayrollDetailRow))]
    public class PayrollDetailController : Controller
    {
        [Route("Payroll/PayrollDetail")]
        public ActionResult Index()
        {
            return View("~/Modules/Payroll/PayrollDetail/PayrollDetailIndex.cshtml");
        }
    }
}