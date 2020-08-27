using Znaltyics.Group1.FoodOrdering.Entities;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class EmployeDataAccess
    {

        private List<Employee> _employee;

        static EmployeeDataAccess()
        {
            _employee = new List<Employee>();
        }
        new Employee()

        /// <summary>
        /// adding employee
        /// </summary>
        /// <param name="f"></param>
        public void Add(Employee f)
        {
            _employee.Add(f);
        }
    }
}