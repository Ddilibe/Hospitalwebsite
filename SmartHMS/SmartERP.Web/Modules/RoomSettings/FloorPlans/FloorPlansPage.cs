using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(FloorPlansRow))]
    public class FloorPlansController : Controller
    {
        [Route("RoomSettings/FloorPlans")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/FloorPlans/FloorPlansIndex.cshtml");
        }
    }
}