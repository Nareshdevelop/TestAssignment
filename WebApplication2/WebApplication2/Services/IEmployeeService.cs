using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
   public interface IEmployeeService
    {
        List<Employee> GetEmployeeList();
        List<Employee> GetUpdatedEmployeeList( int employeeId, int workDays);
        List<Employee> GetUpdatedVacationDays(int employeeId, int vacationDays);
    }
}
