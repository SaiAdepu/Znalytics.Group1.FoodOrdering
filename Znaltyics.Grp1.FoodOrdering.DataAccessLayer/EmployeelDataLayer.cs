using Znalytics.Group1.FoodOrdering.Entities;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class EmployeeDataLayer
    {
        private List<Employee> _employeeID;
        public EmployeeDataLayer()
        {
            _employeeID = new List<Employee>();
        }
        /// <summary>
        /// adding employee
        /// </summary>
        /// <param name="f"></param>
        public void Add(Employee f)
        {
            _employeeID.Add(f);
        }
    }
}