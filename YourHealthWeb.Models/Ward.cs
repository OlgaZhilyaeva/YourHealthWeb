﻿namespace YourHealthWeb.Models
{
    public class Ward
    {
        public int WardId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}