using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FoodOrdering.DataAccessLayer
{
    public class EmployeeDataAccess: IEmployeeDataAccessLayer
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
        new Employee(){ EmployeeID  = 1, Email ="Shiva@gamil.com",FirstName ="shiva",Password ="Abcuytr4",MobileNumber ="9876543217"},
        new Employee (){ EmployeeID = 2, Email = "abcde@gamil.com",FirstName = "oppooo",LastName = "loto",Password = "Bbodiudic8",MobileNumber = "8976543217"},
        new Employee (){ EmployeeID = 3, Email = "ghjk@gamil.com",FirstName = "vivotry",LastName = "lava",Password = "Dmaagaga543",MobileNumber = "7576543217"},

    };

            /// Adding employee  from the list////////

            void AddEmployee(Employee employee)
            {
                //Address Employee Details to List//////////
                _employees.Add(employee);
                //ListOfEmployee()
            }


            /// Deleting Employee from the List//////////
            void DeleteEmployee(Employee employee)
            {
                _employees.RemoveAll(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName == employee.FirstName);
                //  LIstofEmployee();
            }

            ////   //Get all Employee Details from the list/////
            List<Employee> GetEmployees()
            {
                return _employees;
            }

            //////   // update the employeedetails  based on the employeeid and Name///
            void UpdateEmployeesEmail(Employee employee)
            {
                var xyz = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName == employee.FirstName);

                try
                {
                    if (xyz != null)
                    {
                        xyz.Email = employee.Email;
                        // ListOfEmployees();


                    }
                    else
                    {
                        //      throw new EmployeeException("Entered values employeeId and Name is Invalid");
                    }

                }
                catch
                {
                    throw;
                }
            }
            
       
    
    

