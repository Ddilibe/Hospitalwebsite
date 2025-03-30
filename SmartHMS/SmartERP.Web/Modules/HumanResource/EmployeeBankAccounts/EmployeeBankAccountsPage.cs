
namespace SmartERP.HumanResource.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.EmployeeBankAccountsRow))]
    public class EmployeeBankAccountsController : Controller
    {
        [Route("HumanResource/EmployeeBankAccounts")]
        public ActionResult Index()
        {
            return View("~/Modules/HumanResource/EmployeeBankAccounts/EmployeeBankAccountsIndex.cshtml");
        }
    }
}