using Znaltyics.Group1.FoodOrdering.Entities;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class EmployeDataAccess
    {

        private List<Employee> employee;

        public EmployeeDataAccess()
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