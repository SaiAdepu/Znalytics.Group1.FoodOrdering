using System;
using System.Collections.Generic;
using Znalytics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.Businesslayer
{
     public class EmployeeBusinessLogic
    {
        EmployeesDataAccess _employeesDataAccess;
        
        public EmployeeBusinessLogic()
        {
            _employeeDataAccess = new EmployeeDataAccess();
        }
        public void Email(Employee e){
            if(e.Contains("@") && !e.Contains(" ")){
                EmployeDataAccess dl=new EmployeDataAccess();
                dl.Add(e);
            }
        }
    }
}

        
