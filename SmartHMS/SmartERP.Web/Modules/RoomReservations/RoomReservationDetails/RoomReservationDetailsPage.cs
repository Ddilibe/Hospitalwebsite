using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomReservations.Pages
{

    [PageAuthorize(typeof(RoomReservationDetailsRow))]
    public class RoomReservationDetailsController : Controller
    {
        [Route("RoomReservations/RoomReservationDetails")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomReservations/RoomReservationDetails/RoomReservationDetailsIndex.cshtml");
        }
    }
}