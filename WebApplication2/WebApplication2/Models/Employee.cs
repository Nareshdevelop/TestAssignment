using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {
        private float vacationDays = 0;

        [Range(0, 260)]
        public int WorkDays { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; } 
        public float VacationDays
        {
            get
            { return vacationDays; }
            set
            { vacationDays = value; }
        }
        public  EmployeeType employeeType { get; set; }
       
    }
   public enum EmployeeType
    {
        Hourly,
        Salaried,
        Manager
    }
}
