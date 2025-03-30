using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Payroll.Pages
{

    [PageAuthorize(typeof(PayrollDetailDeductionRow))]
    public class PayrollDetailDeductionController : Controller
    {
        [Route("Payroll/PayrollDetailDeduction")]
        public ActionResult Index()
        {
            return View("~/Modules/Payroll/PayrollDetailDeduction/PayrollDetailDeductionIndex.cshtml");
        }
    }
}