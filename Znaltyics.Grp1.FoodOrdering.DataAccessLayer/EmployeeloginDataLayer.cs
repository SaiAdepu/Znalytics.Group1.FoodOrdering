using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;
    
namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
   public  class EmployeeloginDataLayer
    {
        private List<Employeelogin> _employeeID;
        public EmployeeloginDataLayer()
        {
            _employeeID = new List<Employeelogin>();
        }
        /// <summary>
        /// adding employeeid
        /// </summary>

        public void Add (Employeelogin f) 
        {
            _employeeID.Add (f);
        }
            }
        }
    
