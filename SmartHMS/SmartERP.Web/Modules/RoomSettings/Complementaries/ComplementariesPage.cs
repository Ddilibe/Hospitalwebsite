using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SmartERP.RoomSettings.Pages
{

    [PageAuthorize(typeof(ComplementariesRow))]
    public class ComplementariesController : Controller
    {
        [Route("RoomSettings/Complementaries")]
        public ActionResult Index()
        {
            return View("~/Modules/RoomSettings/Complementaries/ComplementariesIndex.cshtml");
        }
    }
}