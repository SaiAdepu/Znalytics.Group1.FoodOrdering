using FoodOrdering.Entities;
using System.Collections.Generic;

namespace FoodOrdering.DataAccessLayer
{
    public class EmployeeDataAccess //: //IDataAccessLayer
    {
        //store the list of the Employee details

        private static List<Employee> _employees;

        public static int EmployeID = 0;

        //static Constructor created
        static EmployeeDataAccess()
        {
            //Creating object from list
            _employees = new List<Employee>()

            {
        new Employee(){ EmployeeID  ="1001", Email ="Shiva@gamil.com",FirstName ="shiva",LastName ="kumar",Password ="9876",MobileNumber ="9876543217"}
        new Employee (){ EmployeeID = "1002", Email = "abcde@gamil.com",FirstName = "oppooo",LastName = "loto",Password = "1234",MobileNumber = "8976543217"}
        new Employee (){ EmployeeID = "1003", Email = "ghjk@gamil.com",FirstName = "vivotry",LastName = "lava",Password = "6543,MobileNumber = "7576543217"} 

    };

            /// Adding employee  from the list////////

            public void AddEmployees(Employee employee)
            {
         //Address Employee Details to List//////////
                _employees.Add(employee);
                ListofEmployee();
            }


            /// Deleting Employee from the List//////////
            public void DeleteEmployees(Employee employee)
            {
                _employees.RemoveAll(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName == firstname.FirstName)
                   LIstofEmployee();
            } 

         ////   //Get all Employee Details from the list/////
            public List<Employee> GetEmployees()
            {
                return _employees;
            }

        //////   // update the employeedetails  based on the employeeid and Name///
            public void UpdateEmployees(Employee employee)
            {
               var id =_employees.Find(temp=>temp.EmployeeID == employee.EmployeeID && temp.Email == FirstName == firstname.FirstName)
           }
            try
            {
                if (id != null)
                {
                    id.Employee = _employees.Employee;
                    LIstofEmployee();
                }
                else
                {
                    throw new EmployeeException("Entered values employeeId and Name is Invalid");
                }

                }
            catch
            {
                throw
            }
            }