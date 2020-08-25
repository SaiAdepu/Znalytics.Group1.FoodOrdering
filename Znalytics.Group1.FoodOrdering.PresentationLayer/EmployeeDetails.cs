using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    class EmployeeDetails
    {
        static void Main()
        {
           EmployeeDetails f = new  EmployeeDetails();

            System.Console.WriteLine("enter the employeelogin details");

            System.Console.WriteLine("enter the employeeID");
            f.EmployeeID = (System.Convert.ToInt32(System.Console.ReadLine()));
            System.Console.WriteLine(f.EmployeeID);

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

          
        }
    }
}
