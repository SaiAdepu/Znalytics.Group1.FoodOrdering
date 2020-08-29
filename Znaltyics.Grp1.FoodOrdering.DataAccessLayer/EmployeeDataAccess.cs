using Znalytics.Group1.FoodOrdering.EmployeeModule.Entities;
using Znalytics.Grp1.FoodOrdering.EmployeeModule.Businesslayer;
using System.Collections.Generic;

namespace Znaltyics.Grp1.FoodOrdering.EmployeeModule.DataAccessLayer
{
    public class EmployeeDataAccess
    {
        //store the list of the Employee details

        private static List<Employee> _employees;

        //static Constructor created
        static EmployeeDataAccess()
        {
            //Creating object from list
            _employees = new List<Employee>()
            {
        new Employee(){ EmployeeId  ="1001", Email ="Shiva@gamil.com",FirstName ="shiva",LastName ="kumar",Password ="9876",MobileNumber ="9876543217"}
        new Employee (){ EmployeeId = "1002", Email = "abcde@gamil.com",FirstName = "oppooo",LastName = "loto",Password = "1234",MobileNumber = "8976543217"}
        new Employee (){ EmployeeId = "1003", Email = "ghjk@gamil.com",FirstName = "vivotry",LastName = "lava",Password = "6543,MobileNumber = "7576543217"} 

    };

            /// Adding employee  from the list////////

            public void AddEmployee(Employee employee)
            {
                //Address Employee Details to List//////////
                _employees.Add(employee);
                LIstofEmployee();
            }


            /// Deleting Employee from the List//////////
            public void DeleteEmployee(Employee employee)
            {
                _employees.RemoveAll(temp => temp.EmployeeID == employee.EmployeeID && temp.Email == email.Email)
                   LIstofEmployee();
            }
            //Get all Employee Details from the list/////
            public List<Employee> GetEmployee()
            {
                return _employees;
            }
            //update the 