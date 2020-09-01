using System;
using FoodOrdering.BusinessLayer;
using System.Collections.Generic;
using FoodOrdering.Entities;
using System.Runtime.InteropServices;
using System.Data;
using System.Runtime.Remoting.Services;
/// <summary>
/// employee Module of Food ordering //// Food Orderinjg Presentaion layer
/// </summary>
namespace FoodOrdering.PresentationLayer
{
    public class EmployeePresentation
    {
        //    ///////// <summary>
        //    ///////// execution starts from Main Method
        //    ///////// </summary>
        //     static void Main()
        //     {
        //        EmployeePresentation();
        //         Console.ReadKey();
        //   }

        public void EmployeeDisplay()
        {
            int choice = 0;
            do
            {
                //displays employee details  choice any one and enter the details
                Console.WriteLine("Employee Detail");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employee");
                Console.WriteLine("3. Update EmployeeName");
                Console.WriteLine("4. Update EmployeeEmail");
                Console.WriteLine("5. Update EmployeeMobileNumber");
                Console.WriteLine("6. Delete Employee");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ViewEmployee(); break;
                    case 3: UpdateEmployeesName(); break;
                    case 4: UpdateEmployeesEmail(); break;
                    case 5: UpdateEmployeesMobileNumber(); break;
                     case 6: DeleteEmployee();break;

                }                                              

            } while (choice != 0);
        }
        /// <summary>
        /// ADD employee details by using Creating Object from employee
        /// </summary>

        void AddEmployee()
        {
            try
            {
                EmployeeBusinessLayer _employeeBusinessLogic = new EmployeeBusinessLayer();
                ///////creating objects for employee /////////////////// f=employees
                Employee f = new Employee();

                Console.WriteLine("WEL COME TO Znalytics FOOD ORDERING EMPLOYEE LOGIN PAGE");
                Console.WriteLine("enter the employeelogin details");



                //reading employee emailid enter the value from the key board//////
                Console.Write("enter the EmployeeId:  ");
                f.EmployeeID = (Convert.ToInt32(Console.ReadLine()));
                Console.Write(f.EmployeeID);


                //reading employee emeil enter the value from the key board//////

                Console.Write("enter the email:   ");
                f.Email = (Console.ReadLine());
                Console.Write(f.Email);


                Console.Write("enter the EmployeeName:");
                //reading employee FirstName enter the value from the key board//////

                Console.Write("enter the FirstName:");
                f.FirstName = (Console.ReadLine());
                Console.Write(f.FirstName);


                //reading employee LastName enter the value from the key board//////

                Console.WriteLine("enter the LastName: ");
                f.LastName = Console.ReadLine();
                Console.Write(f.LastName);



                //reading employee Password enter the value from the key board//////


                Console.WriteLine("enter the Password: ");
                f.Password = Console.ReadLine();
                Console.Write(f.Password);


                //reading employee Mobilenumber enter the value from the key board//////

                Console.WriteLine("enter the MobileNumber: ");
                f.MobileNumber = Console.ReadLine();
                Console.Write(f.MobileNumber);


                _employeeBusinessLogic.AddEmployees(f);
                Console.WriteLine("employee Added Successfully  \n ");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// View all employee details like employeeid,name,emailId,Mobile NUmber 
        /// </summary>
         void ViewEmployee()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                List<Employee> gh = employeeBusinessLayer.GetEmployees();
                Console.WriteLine(      "EMPLOYEE ID,       EMPLOYEE FIRST NAME,     EMPLOYEE LAST NAME,  EMPLOYEE EMAIL,  EMPLOYEE MOBILE NUMBER");  
                foreach (Employee employee in gh)
                {
                    Console.WriteLine(employee.EmployeeID + ",              " + employee.FirstName +",                      "+ employee.LastName+ ",                     " + employee.Email + ",        " + employee.MobileNumber);
                }
                Console.WriteLine("---------------------------------------------------------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// update employeename based onn the employeeid,EmployeeFirst name
        /// </summary>
        void UpdateEmployeesName()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                Employee employee = new Employee();

                //reading employee emailid enter the value from the key board//////
                Console.Write("Enter Existing EmployeeID: ");
                employee.EmployeeID = (Convert.ToInt32(Console.ReadLine()));
                Console.Write("Enter EmployeeName: ");
                employee.FirstName = Console.ReadLine();
                employeeBusinessLayer.UpdateEmployeesName(employee);
                Console.WriteLine("\nName updated Successfully\n");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        void UpdateEmployeesEmail()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                Employee employee = new Employee();
                //reading employee emailid enter the value from the key board//////

                Console.Write("Enter Employee id: ");
                employee.EmployeeID = int.Parse(Console.ReadLine());
                Console.Write("Enter EmployeeName: ");

                employee.FirstName = Console.ReadLine().ToLower();
                Console.Write("Enter Employee New Email: ");


                employee.Email = Console.ReadLine();
                employeeBusinessLayer.UpdateEmployeesEmail(employee);

                Console.WriteLine("\nEmail Updated successfully.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// update employeename based onn the employeeid,EmployeeFirst name
        /// </summary>

        void UpdateEmployeesMobileNumber()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                Employee employee = new Employee();
                //reading employee EmployeeID enter the value from the key board//////
                Console.Write("Enter Employee id: ");
                employee.EmployeeID = int.Parse(Console.ReadLine());
                //reading employee FirstName enter the value from the key board//////
                Console.Write("Enter EmployeeName: ");
                employee.FirstName = Console.ReadLine();

                //reading employee Mobilenumber enter the value from the key board//////
                Console.Write("Enter Existing Mobile Number: ");
                employee.MobileNumber = (Console.ReadLine());

                employeeBusinessLayer.UpdateEmployeesMobileNumber(employee);
                Console.WriteLine("\nNumber Updated successfully.\n");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // delete employee
        void DeleteEmployee()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------");
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                Employee employee = new Employee();
                //reading employee emailid enter the value from the key board//////


                Console.Write("Enter EmployeetoiD be Delete");
                employee.EmployeeID = int.Parse(Console.ReadLine());

                //reading employee FirstName enter the value from the key board//////
                Console.Write("Enter EmployeeName: to be delete ");
                employee.FirstName = Console.ReadLine();
                Console.Write("Enter  Mobile Number to be delete: ");
                employee.MobileNumber = (Console.ReadLine());

              //  employeeBusinessLayer.DeleteEmployee(employee);
                Console.WriteLine("\n delete employee successfully.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

           }

}


