using System;

namespace YourHealthWeb.Models
{
    public class Temperature
    {
        public int TemperatureId { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }

        public Patient Patient { get; set; }
    }
}