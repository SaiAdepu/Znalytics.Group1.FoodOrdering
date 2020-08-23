using Znaltyics.Group1.FoodOrdering.Entities;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class EmployeeDetail
    {
        private List<EmployeeDetail> employee;

        public EmployeeDetail()
        {
            employee = new List<EmployeeDetail>();
        }
        /// <summary>
        /// adding employee
        /// </summary>
        /// <param name="f"></param>
        public void Add(EmployeeDetail a)
        {
            employee.Add(a);
        }
    }
}