using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(RoomsRow))]
    public class RoomsController : Controller
    {
        [Route("RoomSettings/Rooms")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/Rooms/RoomsIndex.cshtml");
        }
    }
}