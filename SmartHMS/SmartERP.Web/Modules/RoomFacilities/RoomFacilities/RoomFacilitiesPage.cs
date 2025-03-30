using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomFacilities.Pages
{

    [PageAuthorize(typeof(RoomFacilitiesRow))]
    public class RoomFacilitiesController : Controller
    {
        [Route("RoomFacilities/RoomFacilities")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomFacilities/RoomFacilities/RoomFacilitiesIndex.cshtml");
        }
    }
}