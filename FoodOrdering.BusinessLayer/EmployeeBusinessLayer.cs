
/// employeee module from food ordering// Pavan
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;
/// <summary>
/// Food Ordering Bussiness logic Layer
/// </summary>


namespace FoodOrdering.BusinessLayer
{
    public class EmployeeBusinessLayer : IEmployeeBusinessLayer ///Interface
    {
        /// <summary>
        /// create a referaance variable of EmployeeBusinessLayer class
        /// </summary>
        EmployeeDataAccess _employeeDataAccess;
        /// constructor
        public EmployeeBusinessLayer()
        {
            _employeeDataAccess = new EmployeeDataAccess();
        }
        /// <summary>
        ///Add EMPLOYEES( validations of name,email,password,mobile number)
        /// </summary>
        /// <param name="employees"></param>
        public void AddEmployees(Employee employees)
        {
            if (employees.FirstName != null)///First NAME

            {
                if (employees.LastName != null)
                {
                    if (employees.Email.Length >= 6 && employees.Email.Length <= 40)
                    {
                        if (employees.Password != null)
                        {
                            if (employees.MobileNumber != null)
                            {
                            }
                            else
                            {
                                throw new Exception("enter mobile number minimum 10 letters please try again");//Mobile NUmber Exception
                            }
                        }
                        else
                        {
                            throw new Exception("enter password must be minimum 6 characters please try again");   // Password Exception
                        }
                    }

                    else
                    {
                        throw new Exception("enter email must be minimum 6 characters please try again");//Email Exception
                    }
                }
                else
                {
                    throw new Exception("enter Last name must be minimum 6 characters please try again");//Last Name Exception
                }
            }
            else
            {
                throw new Exception("enter First name minimum 6 letters please try again");// first name exception
            }
        }


        /// GetAll Employees
        public List<Employee> GetEmployees()
        {
            return _employeeDataAccess.GetEmployees();

        }
        /// <summary>
        /// Update Employeename 
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployeesName(Employee employee)
        {
            try
            {
                if (employee.FirstName != null)
                {
                    _employeeDataAccess.UpdateEmployeesName(employee);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        /// Update EmployeeEmailemail 

        public void UpdateEmployeesEmail(Employee employee)
        {
            try
            {
                if (employee.Email != null)
                {
                    _employeeDataAccess.UpdateEmployeesEmail(employee);
                }
            }
            catch (Exception e)
            {
                throw;                                           
            }
        }

        /// Update Employee Mobile Number
        public void UpdateEmployeesMobileNumber(Employee employee)
        {
            try
            {
                if (employee.MobileNumber != null)
                {

                    _employeeDataAccess.UpdateEmployeesMobileNumber(employee);
                }
            }catch(Exception e)
            {
                throw;
            }
        }
    }
}









