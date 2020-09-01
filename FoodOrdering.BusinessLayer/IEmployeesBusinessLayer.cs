using FoodOrdering.Entities;
using System.Collections.Generic;


namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Represents Interface employee details 
    /// </summary>
   public interface IEmployeeBusinessLayer
    {
        ///Adding employee details
        void AddEmployees(Employee employees);
      

        List<Employee> GetEmployees();
        //Updating Employee Name(method Name)

        void UpdateEmployeesName(Employee employee);
        //Updating Employee Email(method Name)

        void UpdateEmployeesEmail(Employee employee);
        //Updating Employee MobileNUmber(method Name)

        void UpdateEmployeesMobileNumber(Employee employee);

       
    }
    
    }

