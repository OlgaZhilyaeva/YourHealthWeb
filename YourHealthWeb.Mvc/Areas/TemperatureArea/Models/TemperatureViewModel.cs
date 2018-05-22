using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourHealthWeb.Mvc.Areas.TemperatureArea.Models
{
    public class TemperatureViewModel
    {
        public string NameUser { get; set; }
        public IEnumerable<YourHealthWeb.Models.Temperature> Temperatures { get; set; }
    }
}
