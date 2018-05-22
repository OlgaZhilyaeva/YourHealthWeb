using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;

namespace YourHealthWeb.Mvc.Areas.DepartmentArea.Controllers
{
    public class DepartmentController : Controller
    {
        public IDepartmentProvider DepartmentProvider { get; set; }

        public DepartmentController(IDepartmentProvider departmentProvider)
        {
            DepartmentProvider = departmentProvider;
        }

        public IActionResult DepartmentList()
        {
            var departments = DepartmentProvider.GetAll();
            return View("~/Areas/DepartmentArea/Views/DepartmentsList.cshtml",departments);
        }
    }
}