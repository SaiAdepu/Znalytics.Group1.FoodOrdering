using Znaltyics.Group1.FoodOrdering.Entities;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class EmployeeDataLayer
    {
        private List<Employee> employee;

        public EmployeeDataLayer()
        {
            employee = new List<Employee>();
        }
        /// <summary>
        /// adding employee
        /// </summary>
        /// <param name="f"></param>
        public void Add(Employee a)
        {
            employee.Add(a);
        }
    }
}