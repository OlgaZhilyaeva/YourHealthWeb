using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourHealthWeb.Contracts.Core;
using YourHealthWeb.Mvc.Areas.TemperatureArea.Models;

namespace YourHealthWeb.Mvc.Areas.Temperature.Controllers
{
    public class TemperatureController : Controller
    {
        public ITemperatureProvider TemperatureProvider { get; set; }
        public IPatientProvider PatientProvider { get; set; }

        public TemperatureController(ITemperatureProvider temperatureProvider,IPatientProvider patientProvider)
        {
            TemperatureProvider = temperatureProvider;
            PatientProvider = patientProvider;
        }

        public IActionResult TemperatureList(int id)
        {
            var temperatures = TemperatureProvider.GetAllByPatientId(id);
            var user = PatientProvider.GetById(id);

            TemperatureViewModel model = new TemperatureViewModel()
            {
                NameUser = user.Name+user.Surname,
                Temperatures = temperatures
            };
            return View("~/Areas/TemperatureArea/Views/PatientTemperaturePage.cshtml",model);
        }
    }
}