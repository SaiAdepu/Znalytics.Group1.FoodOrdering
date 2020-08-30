
﻿using  System;
using System.Collections.Generic;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
    public class EmployeeBusinessLayer // : IEmployeeBusinessLayer ///Interface
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

        public void AddEmployees(Employee employees)
        {
            if (employees.FirstName.Length >= 4 && employees.FirstName.Length <= 20)
            {

                if (employees.LastName.Length >= 4 && employees.LastName.Length <= 20)
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




        ///update the empoyee id
        public int UpdateEmployees(int EmployeeID)
        {
            try
            {
                return _employeeDataAccess.UpdateEmployees(EmployeeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        ///Delete the employeeID
        public void DeleteEmployees(int DeleteEmployeeID)
        {
            try
            {
              //  return _employeeDataAccess//.DeleteEmployees(DeleteEmployeeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

    }
}
