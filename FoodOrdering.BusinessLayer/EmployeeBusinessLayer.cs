
﻿using  System;
using System.Collections.Generic;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;

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
        /// add EMPLOYEES( validations of name,email,password,mobile number)
        /// </summary>
        /// <param name="employees"></param>
        public void AddEmployees(Employee employees)
        {
            if (employees.FirstName != null)

            {
                if (employees.LastName != null)
                {
                    if (employees.Email.Length >= 6 && employees.Email.Length <= 40)
                    {
                        if (employees.Password.Length >= 6 && employees.Password.Length <= 15)
                        {
                            if (employees.MobileNumber != null)
                            {
                            }
                            else
                            {
                                throw new Exception("entern mobile number minimum 10 letters please try again");
                            }
                        }
                        else
                        {
                            throw new Exception("enter password must be minimum 6 characters please try again");
                        }
                    }

                    else
                    {
                        throw new Exception("entern email must be minimum 6 characters please try again");
                    }
                }
                else
                {
                    throw new Exception("enter Last name must be minimum 6 characters please try again");
                }
            }
            else
            {
                throw new Exception("enter First name minimum 6 letters please try again");
            }
        }


        /// GetAll Employees
        public List<Employee> GetEmployees()
        {
            return _employeeDataAccess.GetEmployees();
        }
        /// Update EmployeeEmailid 

        public void UpdateEmployeesEmail(Employee employee)
        {
            if (employee.Email != null)
            {
                _employeeDataAccess.UpdateEmployeesEmail(employee);
            }
        }
        /// Update Employee Mobile Number
        public void UpdateEmployeesMobileNumber(Employee employee)
        {
            if (employee.MobileNumber != null)
            {

                _employeeDataAccess.UpdateEmployeesMobileNumber(employee);
            }
        }
    }
}







       

