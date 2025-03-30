using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(BedTypesRow))]
    public class BedTypesController : Controller
    {
        [Route("RoomSettings/BedTypes")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/BedTypes/BedTypesIndex.cshtml");
        }
    }
}