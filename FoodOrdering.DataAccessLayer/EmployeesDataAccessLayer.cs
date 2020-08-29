using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.DataAccessLayer
{
    public interface IDataAccessLayer
    {
        ///ADDING EMPLOYEE DETAILS//////
       
     void AddEmployees(Employee employees);

        ///updateing the employee details/////
       
        List<Employee> GetEmployee();

        Employee GetEmployees(int employeeID);


      ///  List<Employee> GetEmployees();


    }
}
