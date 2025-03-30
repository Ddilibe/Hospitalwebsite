using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.Payroll.Pages
{

    [PageAuthorize(typeof(PayrollDetailIncomeRow))]
    public class PayrollDetailIncomeController : Controller
    {
        [Route("Payroll/PayrollDetailIncome")]
        public ActionResult Index()
        {
            return View("~/Modules/Payroll/PayrollDetailIncome/PayrollDetailIncomeIndex.cshtml");
        }
    }
}