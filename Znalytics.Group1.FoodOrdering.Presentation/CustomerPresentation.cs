using System;
using System.Collections.Generic;
using Znalytics.Grp1.FoodOrdering.BusinessLayer;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Group1.FoodOrdering
{
    class Program
    {
        static void Main()
        {
            CustomerPresentation();
            Console.ReadKey();
        }

        static void CustomerPresentation()
        {
            int choice = 0;
            do
            {
                //displays customer menu
                Console.WriteLine("CUSTOMERS MENU");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customer);
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Delete Customer");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: ViewCustomer(); break;
                    case 3: UpdateCustomer(); break;
                    case 4: DeleteCustomer();break;
           
                }
            } while (choice != 5);
        }

        //adding customer details
        static void AddCustomer()
        {
            CustomerBusinessLogic customerBusinessLogic = new customerBusinessLogic();
            Customer customer = new Customer ();

            Console.Write("Enter CustomerName: ");
            customer.CustomerName = Console.ReadLine();
            Console.Write("Enter CustomerId: ");
            customer.CustomerId = Console.ReadLine();
            Console.Write("Enter CustomerEmail: ");
            customer.CustomerEmail = Console.ReadLine();
            Console.Write("Enter CustomerPhoneNumber: ");
            customer.CustomerPhoneNumber = Console.ReadLine();
            Console.Write("Enter CustomerAddress: ");
            customer.CustomerAddress = Console.ReadLine();
            Console.Write("Enter CustomerPassword: ");
            customer.CustomerPassword = Console.ReadLine();

            customerBusinessLayer.Add(customer);
            Console.WriteLine("Customer Added Successfully.\n");
        }

        static void Viewcustomers()
        {
            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
            List<Customer> custs = customerBusinessLayer.GetCustomer();

            foreach (Customer cust in custs)
            {
                Console.WriteLine(cust.CustomerName + ", " + cust.CustomerId + "," + cust.CustomerEmail + "," +cust.CustomerPhoneNumber + "," +cust.CustomerAddress + "," + cust.CustomerPassword);
            }
        }

        static void UpdateCustomer()
        {
            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
            Customer customer = new Customer();
            Console.Write("Enter Existing CustomerID: ");
            customer.CustomerID = Console.ReadLine();
            Console.Write("Enter New CustomerName: ");
            customer.CustomerName = Console.ReadLine();

            customerBusinessLayer.UpdateCustomer(customer);
            Console.WriteLine("Customer Updated successfully.\n");
        }
    }
}