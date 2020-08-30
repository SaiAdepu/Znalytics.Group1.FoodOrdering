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

        List<Employee> GetEmployee();

        Employee GetEmployees(int employeeID);
        List<Employee> GetEmployee(string employeeName);
        /// <summary>
        /// updating  employeee details
        /// </summary>
        /// <param name="employees"></param>
        void UpdateEmployees(Employee employees);
    }
    
    }

