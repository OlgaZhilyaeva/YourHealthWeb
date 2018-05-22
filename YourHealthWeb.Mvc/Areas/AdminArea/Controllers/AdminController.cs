using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;

namespace YourHealthWeb.Mvc.Areas.AdminArea.Controllers
{
    public class AdminController : Controller
    {
        private IPatientProvider _patientProvider;
        private IUserProvider _userProvider;
        private IDoctorProvider _doctorProvider;
        private INurseProvider _nurseProvider;
        private IHospitalProvider _hospitalProvider;
        private IDepartmentProvider _departmentProvider;
        private IWardProvider _wardProvider;
        private IPrescriptionProvider _prescriptionProvider;
        private IMedicineProvider _medicineProvider;
        private ISensorProvider _sensorProvider;


        public AdminController(IPatientProvider patientProvider, IUserProvider userProvider, IDoctorProvider doctorProvider,
            INurseProvider nurseProvider, IHospitalProvider hospitalProvider, IDepartmentProvider departmentProvider,
            IWardProvider wardProvider, IPrescriptionProvider prescriptionProvider, IMedicineProvider medicineProvider,
            ISensorProvider sensorProvider)
        {
            _patientProvider = patientProvider;
            _userProvider = userProvider;
            _doctorProvider = doctorProvider;
            _nurseProvider = nurseProvider;
            _hospitalProvider = hospitalProvider;
            _departmentProvider = departmentProvider;
            _wardProvider = wardProvider;
            _prescriptionProvider = prescriptionProvider;
            _medicineProvider = medicineProvider;
            _sensorProvider = sensorProvider;
        }

        public IActionResult Patients()
        {
            var patients = _patientProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Patients.cshtml",patients);
        }

        public IActionResult Users()
        {
            var users = _userProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Users.cshtml",users);
        }

        public IActionResult Doctors()
        {
            var doctors = _doctorProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Doctors.cshtml",doctors);
        }

        public IActionResult Nurses()
        {
            var nurses = _nurseProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Nurses.cshtml",nurses);
        }

        public IActionResult Departments()
        {
            var departments = _departmentProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Departments.cshtml",departments);
        }

        public IActionResult Wards()
        {
            var wards = _wardProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Wards.cshtml", wards);
        }

        public IActionResult Prescriptions()
        {
            var prescriptions = _prescriptionProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Prescriptions.cshtml",prescriptions);
        }

        public IActionResult Sensors()
        {
            var sensors = _sensorProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Sensors.cshtml", sensors);
        }

        public IActionResult Medicines()
        {
            var medicines = _medicineProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Medicines.cshtml", medicines);
        }

        public IActionResult Hospitals()
        {
            var hospitals = _hospitalProvider.GetAll();
            return View("~/Areas/AdminArea/Views/Hospitals.cshtml", hospitals);
        }
    }
}