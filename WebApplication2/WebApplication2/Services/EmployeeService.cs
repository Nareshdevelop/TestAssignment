using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployeeList()
        {
            var list = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee
                {
                    EmployeeId = i,
                    Name = "John" + i.ToString(),
                    employeeType = EmployeeType.Hourly,
                    VacationDays = 10,
                    WorkDays = 0
                };
                list.Add(emp);
            }
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee
                {
                    EmployeeId = 10 + i,
                    Name = "John" + i.ToString(),
                    employeeType = EmployeeType.Salaried,
                    VacationDays = 15,
                    WorkDays = 0
                };
                list.Add(emp);
            }
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee
                {
                    EmployeeId = 20 + i,
                    Name = "John" + i.ToString(),
                    employeeType = EmployeeType.Manager,
                    VacationDays = 30,
                    WorkDays = 0
                };
                list.Add(emp);
            }
            return list;
        }

        public List<Employee> GetUpdatedEmployeeList(int employeeId, int workDays)
        {
            var employees = GetEmployeeList();
            Employee updatedEmployee = employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
            updatedEmployee.WorkDays = workDays;
            if (updatedEmployee.employeeType == EmployeeType.Hourly)
            {
                updatedEmployee.VacationDays = workDays / 260 * 10;
            }
            else if (updatedEmployee.employeeType == EmployeeType.Salaried)
            {
                updatedEmployee.VacationDays = workDays / 260 * 15;
            }
            else
            {
                updatedEmployee.VacationDays = workDays / 260 * 130;
            }
            return employees;
        }

        public List<Employee> GetUpdatedVacationDays(int employeeId, int vacationDays)
        {
            var employees = GetEmployeeList();
            Employee updatedEmployee = employees.Where(x => x.EmployeeId == employeeId).FirstOrDefault();
          if(updatedEmployee.VacationDays != 0 && updatedEmployee.VacationDays >= vacationDays)
            {

           
            if (updatedEmployee.employeeType == EmployeeType.Hourly)
            {
                if(vacationDays <= 10)
                {
                    updatedEmployee.VacationDays -= vacationDays;
                }
              
            }
            else if (updatedEmployee.employeeType == EmployeeType.Salaried)
            {
                if (vacationDays <= 15)
                {
                    updatedEmployee.VacationDays -= vacationDays;
                }
            }
            else
            {
                if (vacationDays <= 30)
                {
                    updatedEmployee.VacationDays -= vacationDays;
                }
            }
            }
            return employees;
        }
    }
}
