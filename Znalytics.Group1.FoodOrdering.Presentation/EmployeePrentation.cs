using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    class EmployeeDetail
    {

        static void AddEmployee()
        {
            EmployeeBusinessLogic _employeeBusinessLogic = new EmployeeBusinessLogic();
            Employee f = new Employee();

            System.Console.WriteLine("enter the employee details");

            Console.WriteLine("enter the employeeID");
            f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine(f.EmployeeID);

            System.Console.WriteLine("enter the email");
            f.Email = (System.Console.ReadLine());
            System.Console.WriteLine(f.Email);

            System.Console.WriteLine("enter the EmployeeName");

            System.Console.WriteLine("enter the FirstName");
            f.FirstName = (System.Console.ReadLine());
            System.Console.WriteLine(f.FirstName);

            System.Console.WriteLine("enter the LastName");
            f.LastName = (System.Console.ReadLine());
            System.Console.WriteLine("enter the Name:" + f.LastName);

            System.Console.WriteLine("enter the Password");
            f.Password = (System.Console.ReadLine());
            System.Console.WriteLine(f.Password);



            System.Console.WriteLine("enter the MobileNumber");
            f.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
            System.Console.WriteLine(f.MobileNumber);

            EmployeeBusinessLogic.Add(f);
            Console.WriteLine("employee Added Successfully  \n ");


        }
    }
}
