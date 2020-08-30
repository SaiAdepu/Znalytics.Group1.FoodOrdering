﻿using System;
using FoodOrdering.BusinessLayer;
using System.Collections.Generic;
using FoodOrdering.Entities;

namespace FoodOrdering.PresentationLayer
{
    class EmployeePL
    {
        /// <summary>
        /// execution starts from Main Method
        /// </summary>
        static void Main()
        {
            EmployeePresentation();
            Console.ReadKey();
        }

        static void EmployeePresentation()
        {
            int choice = 0;
            do
            {
                //displays employee menu
                Console.WriteLine("Employee Detail");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;

                    case 2: UpdateEmployee(); break;
                   // case 3: DeleteEmployee(); break;
                   // case 4: Exit(); break;

                }
            } while (choice != 5);
        }

        static void AddEmployee()
        {
            EmployeeBusinessLayer _employeeBusinessLogic = new EmployeeBusinessLayer();
            ///////creating objects for employee ///////////////////
            Employee f = new Employee();

            Console.WriteLine("WEL COME TO Znalytics FOOD ORDERING EMPLOYEE LOGIN PAGE");
            Console.WriteLine("enter the employeelogin details");


            f.EmployeeID = ++Employee.EmployeeIDCount;

            //reading employee emailid enter the value from the key board//////
            Console.WriteLine("enter the email");
            f.Email = (System.Console.ReadLine());
            System.Console.WriteLine(f.Email);

            System.Console.WriteLine("enter the EmployeeName");
            //reading employee FirstName enter the value from the key board//////

            System.Console.WriteLine("enter the FirstName");
            f.FirstName = (System.Console.ReadLine());
            System.Console.WriteLine(f.FirstName);

            //reading employee LastName enter the value from the key board//////
            System.Console.WriteLine("enter the LastName");
            f.LastName = (System.Console.ReadLine());
            System.Console.WriteLine("enter the Name:" + f.LastName);

            //reading employee Password enter the value from the key board//////
            System.Console.WriteLine("enter the Password");
            f.Password = (System.Console.ReadLine());
            System.Console.WriteLine(f.Password);


            //reading employee Mobilenumber enter the value from the key board//////
            System.Console.WriteLine("enter the MobileNumber");
            f.MobileNumber = (System.Console.ReadLine());
            System.Console.WriteLine(f.MobileNumber);

            _employeeBusinessLogic.AddEmployees(f);
            Console.WriteLine("employee Added Successfully  \n ");

        }
        static void UpdateEmployee()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee f = new Employee();
            Console.Write("Enter Existing EmployeeID: ");
            f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));


           // EmployeeBusinessLayer.UpdateEmployees(f);
            //Console.WriteLine("CustomerName Updated successfully.\n");
        }

    }

   // static void DeleteEmployee()
   // {
     ///   EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
     ///   Employee f = new Employee();
      ///  Console.Write("Enter Existing EmployeeID: ");
      // f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));
    }

     ///   static void Exit()
      ///  {
     //       EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
      //      Employee f = new Employee();
   //         Console.Write("Enter Existing EmployeeID: ");
     //       f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));K
    //    }
   // }

