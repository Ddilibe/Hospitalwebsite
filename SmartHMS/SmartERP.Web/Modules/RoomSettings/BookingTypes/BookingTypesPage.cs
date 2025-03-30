using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(BookingTypesRow))]
    public class BookingTypesController : Controller
    {
        [Route("RoomSettings/BookingTypes")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/BookingTypes/BookingTypesIndex.cshtml");
        }
    }
}