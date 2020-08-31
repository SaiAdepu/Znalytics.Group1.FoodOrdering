//using System;
//using System.Collections.Generic;
//using FoodOrdering.BusinessLayer;
//using FoodOrdering.Entities;

//namespace FoodOrdering.PresentationLayer
//{
//    class Program
//    {
//       static void Main()
//        {
//            CustomerPresentation();
//            Console.ReadKey();
//        }

//        static void CustomerPresentation()
//        {
//            int choice = 0;
//            do
//            {
//                //displays customer menu
//                Console.WriteLine("CUSTOMERS MENU");
//                Console.WriteLine("1. Add Customer");
//                Console.WriteLine("2. View Customer");
//                Console.WriteLine("3. Update CustomerName");
//                Console.WriteLine("4. Update CustomerEmail");
//                Console.WriteLine("5. Update CustomerPhoneNumber");
//                Console.WriteLine("6. Update CustomerAddress");
//                Console.WriteLine("7. Update CustomerPassword");
//                Console.WriteLine("8. Delete Customer");
//                Console.WriteLine("9. Exit");
//                Console.Write("Enter choice: ");
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1: AddCustomer(); break;
//                    case 2: Viewcustomers(); break;
//                    case 3: UpdateCustomerName(); break;
//                    case 4: UpdateCustomerEmail(); break;
//                    case 5: UpdateCustomerPhoneNumber(); break;
//                    case 6: UpdateCustomerAddress(); break;
//                    case 7: UpdateCustomerPassword(); break;
//                    case 8: DeleteCustomer();break; 
           
//                }
//            } while (choice != 9);
//        }

//        //adding customer details
//        static void AddCustomer()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer ();
//            try
//            {
//                Console.Write("Enter CustomerName: ");
//                customer.CustomerName = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                Console.Write("Enter CustomerId: ");
//                customer.CustomerId = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                Console.Write("Enter CustomerEmail: ");
//                customer.CustomerEmail = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                Console.Write("Enter CustomerPhoneNumber: ");
//                customer.CustomerPhoneNumber = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                Console.Write("Enter CustomerAddress: ");
//                customer.CustomerAddress = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                Console.Write("Enter CustomerPassword: ");
//                customer.CustomerPassword = Console.ReadLine();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            customerBusinessLayer.AddCustomer(customer);
//            Console.WriteLine("Customer Added Successfully.\n");
//        }

//        static void Viewcustomers()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            List<Customer> custs = customerBusinessLayer.GetCustomers();

//            foreach (Customer cust in custs)
//            {
//                Console.WriteLine(cust.CustomerName + ", " + cust.CustomerId + "," + cust.CustomerEmail + "," +cust.CustomerPhoneNumber + "," +cust.CustomerAddress + "," + cust.CustomerPassword);
//            }
//        }

//        static void UpdateCustomerName()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter Existing CustomerID: ");
//            customer.CustomerId = Console.ReadLine();
//            Console.Write("Enter New CustomerName: ");
//            customer.CustomerName = Console.ReadLine();

//            customerBusinessLayer.UpdateCustomerName(customer);
//            Console.WriteLine("CustomerName Updated successfully.\n");
//        }
//        static void UpdateCustomerEmail()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter Existing CustomerID: ");
//            customer.CustomerId = Console.ReadLine();
//            Console.Write("Enter New CustomerEmail: ");
//            customer.CustomerEmail = Console.ReadLine();

//            customerBusinessLayer.UpdateCustomerEmail(customer);
//            Console.WriteLine("CustomerEmail Updated successfully.\n");
//        }
//        static void UpdateCustomerPhoneNumber()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter Existing CustomerID: ");
//            customer.CustomerId = Console.ReadLine();
//            Console.Write("Enter New CustomerPhoneNumber: ");
//            customer.CustomerPhoneNumber = Console.ReadLine();

//            customerBusinessLayer.UpdateCustomerPhoneNumber(customer);
//            Console.WriteLine("CustomerPhoneNumber Updated successfully.\n");
//        }
//        static void UpdateCustomerAddress()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter Existing CustomerID: ");
//            customer.CustomerId = Console.ReadLine();
//            Console.Write("Enter New CustomerAddress: ");
//            customer.CustomerAddress = Console.ReadLine();

//            customerBusinessLayer.UpdateCustomerAddress(customer);
//            Console.WriteLine("CustomerAddress Updated successfully.\n");
//        }
//        static void UpdateCustomerPassword()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter Existing CustomerID: ");
//            customer.CustomerId = Console.ReadLine();
//            Console.Write("Enter New CustomerPassword: ");
//            customer.CustomerPassword = Console.ReadLine();

//            customerBusinessLayer.UpdateCustomerPassword(customer);
//            Console.WriteLine("CustomerPassword Updated successfully.\n");
//        }
//        static void DeleteCustomer()
//        {
//            CustomerBusinessLayer customerBusinessLayer = new CustomerBusinessLayer();
//            Customer customer = new Customer();
//            Console.Write("Enter customerName to be deleted: ");
//            customer.CustomerName = Console.ReadLine();
//            Console.Write("Enter customerId to be deleted: ");
//            customer.CustomerId = Console.ReadLine();

//            customerBusinessLayer.DeleteCustomer(customer);
//            Console.WriteLine("Customer deleted successfully.\n");
//        }
//    }
//}