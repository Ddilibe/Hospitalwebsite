using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.HumanResource.Pages
{

    [PageAuthorize(typeof(EmployeeIncomesRow))]
    public class EmployeeIncomesController : Controller
    {
        [Route("HumanResource/EmployeeIncomes")]
        public ActionResult Index()
        {
            return View("~/Modules/HumanResource/EmployeeIncomes/EmployeeIncomesIndex.cshtml");
        }
    }
}