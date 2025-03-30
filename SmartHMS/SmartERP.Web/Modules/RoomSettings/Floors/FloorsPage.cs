using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(FloorsRow))]
    public class FloorsController : Controller
    {
        [Route("RoomSettings/Floors")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/Floors/FloorsIndex.cshtml");
        }
    }
}