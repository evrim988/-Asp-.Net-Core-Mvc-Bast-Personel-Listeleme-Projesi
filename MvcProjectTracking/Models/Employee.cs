﻿namespace MvcProjectTracking.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age {  get; set; }
        public string FullName => $"{Name} {SurName.ToUpper()}";
    }
}
