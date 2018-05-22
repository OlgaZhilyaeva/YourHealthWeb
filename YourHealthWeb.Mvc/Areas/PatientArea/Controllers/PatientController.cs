using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Models;
using YourHealthWeb.Models.enums;
using YourHealthWeb.Mvc.Areas.PatientArea.Models;

namespace YourHealthWeb.Mvc.Areas.PatientArea.Controllers
{
    public class PatientController : Controller
    {
        public IPatientProvider PatientProvider { get; set; }
        public IPrescriptionProvider PrescriptionProvider { get; set; }
        public ISensorProvider SensorProvider { get; set; }
        public IWardProvider WardProvider { get; set; }
        public IDepartmentProvider DepartmentProvider { get; set; }

        public PatientController(IPatientProvider patientProvider, IPrescriptionProvider prescriptionProvider,
            ISensorProvider sensorProvider, IWardProvider wardProvider, IDepartmentProvider departmentProvider)
        {
            PatientProvider = patientProvider;
            PrescriptionProvider = prescriptionProvider;
            SensorProvider = sensorProvider;
            WardProvider = wardProvider;
            DepartmentProvider = departmentProvider;
        }

        public IActionResult PatientList(int id)
        {
            //GetAllByWardId
            var patients = PatientProvider.GetByWard(id);
            return View("~/Areas/PatientArea/Views/PatientsList.cshtml", patients);
        }

        public IActionResult PersonalPage(int id)
        {
            Patient patient1 = PatientProvider.GetById(id);
            var prescriptions = PrescriptionProvider.GetByPatientId(id);

            PatientViewModel patient = new PatientViewModel()
            {
                Ward = patient1.Ward,
                PatientId = patient1.PatientId,
                Name = patient1.Name,
                Surname = patient1.Surname,
                Sensor = patient1.Sensor,
                Prescriptions = prescriptions.ToList(),
                Documents = patient1.Documents,
                User = patient1.User
            };

            return View("~/Areas/PatientArea/Views/PersonalPage.cshtml",patient);
        }

        [HttpGet]
        public IActionResult AddNewPatient()
        {
            var sensors = SensorProvider.GetAllEnum();
            var wards = WardProvider.GetAllEnum();
            var departments = DepartmentProvider.GetAllEnum();

            ViewBag.Departments = departments;
            ViewBag.Sensors = sensors;
            ViewBag.Wards = wards;

            return View("~/Areas/PatientArea/Views/AddNewPatient.cshtml");
        }

        [HttpPost]
        public IActionResult AddNewPatient(string SelectRole, EnumClass SelectSensor, EnumClass SelectWard,
                                           EnumClass SelectDepartment, string patientName, string patientSurname,
                                           string patientPassword, string patientLogin)
        {
            return View("~/Areas/PatientArea/Views/AddNewPatient.cshtml");
        }

        public void DeletePatient(int id)
        {
            PatientProvider.Delete(id);
        }

    }
}
