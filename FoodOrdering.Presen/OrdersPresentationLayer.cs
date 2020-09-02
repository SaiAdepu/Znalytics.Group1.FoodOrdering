using System;
using System.Collections.Generic;
using System.Collections.Specialized;
//using Orders Entities;
//using OrdersPresentation;

/// <summary>
/// Represents Login Information Of The Orders Details
/// </summary>
namespace Orders.Presentation
{
    class Orders
    {

        //Execution Starts From The Main Method
        static void Main()
        {
            ViewOrders();
            Console.ReadKey();
        }

        //static method shares the same copy of method and its data
        private static void orders()
        {
            int choice = 0;
            //do while loop verifies the condition after execution of statements inside the loop
            do
            {

                //displays foodstore menu
                //display shown based on the option selected 
                Console.WriteLine("OrdersDetails");
                Console.WriteLine("1. Add orders");
                Console.WriteLine("2. View orders");
                Console.WriteLine("3. Update orderid");
                Console.WriteLine("4. View orderDate");
                Console.WriteLine("5. Update userid");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                //switch statement is a control mechanism which executes one case after another till the break statement appears.
                switch (choice)
                {
                    case 1: AddOrders(); break;
                    case 2: UpdateOrderid(); break;
                    case 3: UpdateUserid(); break;
                }
            } while (choice != 0);
        }

        //adding Orders details
        static void AddOrders()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders Orders = new Orders();
            try
            {
                //reading the Orderid manually
                Console.Write("Enter orderid: ");
                Orders.orderid = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                //reading the Userid manually
                Console.Write("Enter Userid: ");
                Orders.userid = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {  //reading the Storeid manually
                Console.Write("Enter Storeid: ");
                Orders.storeid = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {   //reading the Employeeid manually
                Console.Write("Enter Employeeid: ");
                Orders.employeeid = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {  //reading the Foodid manually
                Console.Write("Enter foodid: ");
                Orders.foodid = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            OrdersPresentation.AddOrders(Orders);
            Console.WriteLine("Orders Added Successfully.\n");
        }

        static void ViewOrders()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            List<Orders> O = OrdersPresentation.GetOrders();

            foreach (Orders Orders in O)
            {
                Console.WriteLine(Orders.orderid + ", " + Orders.userid + "," + Orders.storeid + "," + Orders.Employeeid + "," + Orders.Foodid + ",");
            }
        }
        //updating Orderid
        static void UpdateOrderid()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders orders = new Orders();
            Console.Write("Enter Existing orderid: ");
            orders.orderid = Console.ReadLine();

            //OrdersPresentation.UpdateOrders(orders);
            Console.WriteLine("orders Updated successfully.\n");
        }


        //updating Userid
        static void UpdateUserid()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders orders = new Orders();
            Console.Write("Enter Existing Userid: ");
            orders.userid = Console.ReadLine();
            Console.Write("Enter New Userid: ");
            orders.userid = Console.ReadLine();

            //rdersPresentation.UpdateUserid(Orders);
            Console.WriteLine("Userid Updated successfully.\n");
        }

        //updating storeid
        static void UpdateStoreid()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders orders = new Orders();
            Console.Write("Enter Existing storeid: ");
            orders.storeid = Console.ReadLine();
            Console.Write("Enter New storeid: ");
            orders.storeid = Console.ReadLine();

            //rdersPresentation.Updatestoreid(Orders);
            Console.WriteLine("storeid Updated successfully.\n");
        }

        //updating employeeid
        static void Updateemployeeid()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders orders = new Orders();
            Console.Write("Enter Existing employeeid: ");
            orders.employeeid = Console.ReadLine();
            Console.Write("Enter New employeeid: ");
            orders.employeeid = Console.ReadLine();

            //rdersPresentation.Updateemployeeid(Orders);
            Console.WriteLine("employeeid Updated successfully.\n");
        }

        //updating foodid
        static void Updatefoodid()
        {
            OrdersPresentation ordersPresentation = new OrdersPresentation();
            Orders orders = new Orders();
            Console.Write("Enter Existing foodid: ");
            orders.foodid = Console.ReadLine();
            Console.Write("Enter New foodid: ");
            orders.foodid = Console.ReadLine();

            //rdersPresentation.Updatefoodid(Orders);
            Console.WriteLine("foodid Updated successfully.\n");
        }


    }

}
