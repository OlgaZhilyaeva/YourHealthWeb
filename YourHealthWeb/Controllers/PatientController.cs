using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;

namespace YourHealthWeb.View.Controllers
{
    public class PatientController : Controller
    {
        public IPatientProvider PatientProvider { get; set; }
        public PatientController(IPatientProvider patientProvider)
        {
            PatientProvider = patientProvider;
        }

        public IActionResult Index()
        {
            var z = PatientProvider.GetAll();
            return View("PersonalPage");
        }
    }
}