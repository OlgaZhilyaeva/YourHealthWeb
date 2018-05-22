using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourHealthWeb.Models;

namespace YourHealthWeb.Mvc.Areas.PatientArea.Models
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Documents { get; set; }

        public List<Prescription> Prescriptions { get; set; }

        public Sensor Sensor { get; set; }
        public HospitalUser User { get; set; }
        public YourHealthWeb.Models.Ward Ward { get; set; }

    }
}
