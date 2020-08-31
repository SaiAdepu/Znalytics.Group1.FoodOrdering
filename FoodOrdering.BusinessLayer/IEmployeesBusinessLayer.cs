using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         void UpdateEmployeesEmail(Employee employee);

       void UpdateEmployeesMobileNumber(Employee employee);

       
    }
    
    }

