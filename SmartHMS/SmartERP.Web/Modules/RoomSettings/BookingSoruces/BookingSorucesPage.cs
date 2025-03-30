using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(BookingSorucesRow))]
    public class BookingSorucesController : Controller
    {
        [Route("RoomSettings/BookingSoruces")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/BookingSoruces/BookingSorucesIndex.cshtml");
        }
    }
}