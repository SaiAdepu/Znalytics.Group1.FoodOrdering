ng System;
using System.Runtime.InteropServices.WindowsRuntime;
using Znaltyics.Grp1.FoodOrdering.EmployeeModule.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.EmployeeModule.Entities;

namespace Znalytics.Grp1.FoodOrdering.EmployeeModule.Businesslayer
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
    }

    public string AddEmployees(Employee employees)

    {
        /// if the EmployeeID is exits its shows already exists
        if (_employeeDataAccess.IsEmployeeIDExist(employees.EmployeeID))
        {

            return "employeeid Already taken by other user please try  a different one";
        }
        /// if the emailid is exits its shows already exists
        if (_employeeDataAccess.IsEmailExist(employees.Email))
        {

            return "Email Address already exists";
        }

        try

        {

            return _employeeDataAccess.AddEmployees(employees);

        }

        catch (Exception ex)

        {

            throw ex;

        }

    }
    ///update the empoyee id
    public bool UpdateEmployees(int EmployeeID)
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
    public void DeleteEmployees(int deleteEmployeeID)
    {
        try
        {
            return _employeeDataAccess.DeleteEmployees(deleteEmployeeID);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



