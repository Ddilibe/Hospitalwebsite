﻿using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SmartERP.Administration.Pages
{
    [PageAuthorize(typeof(Entities.RoleRow))]
    public class RoleController : Controller
    {
        [Route("Administration/Role")]
        public ActionResult Index()
        {
            return View(MVC.Views.Administration.Role.RoleIndex);
        }
    }
}