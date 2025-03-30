using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomFacilities.Pages
{

    [PageAuthorize(typeof(RoomSizesRow))]
    public class RoomSizesController : Controller
    {
        [Route("RoomFacilities/RoomSizes")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomFacilities/RoomSizes/RoomSizesIndex.cshtml");
        }
    }
}