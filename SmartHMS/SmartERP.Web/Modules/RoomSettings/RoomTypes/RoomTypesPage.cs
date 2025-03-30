using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(RoomTypesRow))]
    public class RoomTypesController : Controller
    {
        [Route("RoomSettings/RoomTypes")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/RoomTypes/RoomTypesIndex.cshtml");
        }
    }
}