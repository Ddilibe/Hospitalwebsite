using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(RoomImagesRow))]
    public class RoomImagesController : Controller
    {
        [Route("RoomSettings/RoomImages")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/RoomImages/RoomImagesIndex.cshtml");
        }
    }
}