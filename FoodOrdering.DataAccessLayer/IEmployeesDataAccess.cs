using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.DataAccessLayer
{
    public interface IEmployeeDataAccessLayer
    {
        ///ADDING EMPLOYEE DETAILS//////

        void AddEmployee(Employee employee);

        ///updateing the employee details/////

        List<Employee> GetEmployees();

        Employee GetEmployeeByEmployeeID(int employeeID);

        List<Employee> GetEmployeesByEmployeeName(string employeeName);

        void DeleteEmployee(Employee employee);
        void UpdateEmployeesName(Employee employee);


        void UpdateEmployeesEmail(Employee employee);
        void UpdateEmployeesMobileNumber(Employee employee);

    }
}
