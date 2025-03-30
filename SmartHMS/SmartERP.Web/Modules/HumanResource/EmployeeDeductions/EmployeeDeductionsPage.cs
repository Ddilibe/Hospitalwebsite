using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.HumanResource.Pages
{

    [PageAuthorize(typeof(EmployeeDeductionsRow))]
    public class EmployeeDeductionsController : Controller
    {
        [Route("HumanResource/EmployeeDeductions")]
        public ActionResult Index()
        {
            return View("~/Modules/HumanResource/EmployeeDeductions/EmployeeDeductionsIndex.cshtml");
        }
    }
}