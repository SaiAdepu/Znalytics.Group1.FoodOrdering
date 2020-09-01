using FoodOrdering.Entities;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FoodOrdering.DataAccessLayer
{
    public class EmployeeDataAccess : IEmployeeDataAccessLayer
    {
        //store the list of the Employee details              

        private static List<Employee> _employees;
   
        ///static Constructor created
        static EmployeeDataAccess()
        {
           ///Creating object from list
            _employees = new List<Employee>()

            {
                new Employee(){ EmployeeID  = 1, Email ="Shiva@gmail.com",FirstName ="shiva",LastName = "kumar",Password ="Abcuytr4",MobileNumber ="9876543217"},
                new Employee (){ EmployeeID = 2, Email = "abcde@gmail.com",FirstName = "oppooo",LastName = "loto",Password = "Bbodi5",MobileNumber = "8976543217"},
                new Employee (){ EmployeeID = 3, Email = "ghjk@gmail.com",FirstName = "vivotry",LastName = "lava",Password = "Dmaa5",MobileNumber = "7576543217"},

            };
        }


        /// Adding employee  from the list///

        public void AddEmployee(Employee employee)
        {
           ///Address Employee Details to List///
            _employees.Add(employee);
            ///ListOfEmployee
        }


        /// Deleting Employee from the List//////////
        public void DeleteEmployee(Employee employee)
        {
            _employees.RemoveAll(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName == employee.FirstName);
            // LIstofEmployee
        }

        ///Get all Employee Details from the list///
        public List<Employee> GetEmployees()
        {
            if (_employees.Count != 0)

                return _employees;
        
        else
            {
                throw new Exception("  invalid employee details    ");
            }
        }
       
        
        
        /// <summary>
        /// Get the employee based on the  EmployeeID
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public Employee GetEmployeeByEmployeeID(int employeeID)
        {
            return _employees.FirstOrDefault(temp => temp.EmployeeID == employeeID);
        }
        /// <summary>
        /// Get the employee based on the  EmployeeName (
        /// </summary>
        /// <param name="employeeName"></param>
        /// <returns></returns>

        public List<Employee> GetEmployeesByEmployeeName(string employeeName)
        {
            return _employees.Where(temp => temp.FirstName.Contains(employeeName) || temp.LastName.Contains(employeeName)).ToList();
        }
       //// method to Update Employee name
             public void UpdateEmployeesName(Employee employee)
           {
                  //Get matching customer based on employeeID
                  Employee emp = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID);
               if (emp != null)
                 {
                emp.FirstName = employee.FirstName;
                 }
             }
        //method to update customer password
        public void UpdateEmployeePassword(Employee employee)
        {
            //Get matching customer based on CustomerID
            Employee emp = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID);
            if (emp != null)
            {
                emp.Password = employee.Password;
            }
        }
        //////   // update the employeedetails  based on the employeeid and Name///
        public void UpdateEmployeesEmail(Employee employee)
        {
            Employee xyz = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName.ToLower().Equals( employee.FirstName));

            try
            {
                if (xyz != null)
                {
                    xyz.Email = employee.Email;
                    // ListOfEmployees();


                }
                else
                {
                        throw new Exception("Entered values employeeId and Name is Invalid");
                }

            }
            catch
            {
                throw;
            }
        }

        public void UpdateEmployeesMobileNumber(Employee employee)
        {
            Employee d = _employees.Find(temp => temp.EmployeeID == employee.EmployeeID && temp.FirstName.ToLower().Equals(employee.FirstName));

            try
            {

                if (d != null)
                {
                    d.MobileNumber = employee.MobileNumber;

                }
                else
                {
                    throw new Exception("Entering employee id name is in correct try again correct name ");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

