using System;
using Znalytics.Group1.FoodOrdering.Entities;

class Employeev
{
   

    static void Main()
    {
        Employee f = new Employee();

        Console.WriteLine("enter the employeelogin details");

        Console.WriteLine("enter the employeeID");
        f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine(f.EmployeeID);

        Console.WriteLine("enter the EmployeeName");

        Console.WriteLine("enter the FirstName");
        f.FirstName = (Console.ReadLine());
        Console.WriteLine(f.FirstName);

        Console.WriteLine("enter the LastName");
        f.LastName = (Console.ReadLine());
        Console.WriteLine("enter the Name:" + f.LastName);

        Console.WriteLine("enter the Password");
        f.Password = (Console.ReadLine());
        Console.WriteLine(f.Password);

        Console.WriteLine("enter the ConfirmPassword");
        f.ConfirmPassword = (Console.ReadLine());
        Console.WriteLine(f.ConfirmPassword); ;

        Console.WriteLine("enter the MobileNumber");
        f.MobileNumber = (Convert.ToInt64(Console.ReadLine()));
        System.Console.WriteLine(f.MobileNumber);

        Console.WriteLine("enter the Food storeid ");
        f.FoodStoreID = (Console.ReadLine());
        Console.WriteLine(f.FoodStoreID);
    }
}

