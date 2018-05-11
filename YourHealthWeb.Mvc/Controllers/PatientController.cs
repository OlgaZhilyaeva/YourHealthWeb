using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;

namespace YourHealthWeb.Mvc.Controllers
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
            var patients = PatientProvider.GetAll();
            return View("PatientsList",patients);
        }

        public IActionResult PersonalPage()
        {
            return View("PersonalPage");
        }

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
