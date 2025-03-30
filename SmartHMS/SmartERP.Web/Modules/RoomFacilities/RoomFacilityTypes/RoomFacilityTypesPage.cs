using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomFacilities.Pages
{

    [PageAuthorize(typeof(RoomFacilityTypesRow))]
    public class RoomFacilityTypesController : Controller
    {
        [Route("RoomFacilities/RoomFacilityTypes")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomFacilities/RoomFacilityTypes/RoomFacilityTypesIndex.cshtml");
        }
    }
}