using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomReservations.Pages
{

    [PageAuthorize(typeof(RoomReservationsRow))]
    public class RoomReservationsController : Controller
    {
        [Route("RoomReservations/RoomReservations")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomReservations/RoomReservations/RoomReservationsIndex.cshtml");
        }
    }
}