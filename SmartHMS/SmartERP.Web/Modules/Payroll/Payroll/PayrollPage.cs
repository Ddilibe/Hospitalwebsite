using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Payroll.Pages
{

    [PageAuthorize(typeof(PayrollRow))]
    public class PayrollController : Controller
    {
        [Route("Payroll/Payroll")]
        public ActionResult Index()
        {
            return View("~/Modules/Payroll/Payroll/PayrollIndex.cshtml");
        }
    }
}