using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;

namespace YourHealthWeb.Mvc.Areas.Ward.Controllers
{
    public class WardController : Controller
    {
        public IWardProvider WardProvider { get; set; }

        public WardController(IWardProvider wardProvider)
        {
            WardProvider = wardProvider;
        }

        public IActionResult WardList(int id)
        {
            //GetAllByWardId
            var wards = WardProvider.GetAllByDepartmentId(id);
            return View("~/Areas/WardArea/Views/WardsList.cshtml",wards);
        }
    }
}