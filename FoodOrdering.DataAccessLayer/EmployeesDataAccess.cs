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
       
     void AddEmployees(Employee employees);

                                   ///updateing the employee details/////
       
      public  List<Employee> GetEmployee();

       public  Employee GetEmployeeByID(int employeeID);

        public List<Employee> GetEmployeeByName(string employeeName);

        void DeleteEmployees(Employee employee);
        List<Employee> GetEmployees();

        void UpdateEmployees(Employee employee);
       





    }
}
