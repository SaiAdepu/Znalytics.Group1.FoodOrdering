using System;
using System.Collections.Generic;
using FoodOrdering.BusinessLayer;
using FoodOrdering.Entities;

using System.Collections.Specialized;
//using Orders Entities;
//using OrdersPresentation;

/// <summary>
/// Represents Login Information Of The Orders Details
/// </summary>
namespace FoodOrdering.PresentationLayer
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
                Console.WriteLine("4. update orderDate");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                //switch statement is a control mechanism which executes one case after another till the break statement appears.
                switch (choice)
                {
                    case 1: AddOrders(); break;
                    case 2: ViewOrders(); break;
                    case 3: UpdateOrderid();break;
            
                }
            } while (choice != 0);
        }

        //adding Orders details////
        static void AddOrders()
        {
            OrdersBusinessLayer ordersBusinessLayer = new OrdersBusinessLayer();
            Order order = new Order();
           
                //reading the Orderid manually
                Console.Write("Enter orderid: ");
                order.Orderid = int.Parse(Console.ReadLine());
         
             //reading the Storeid manually
                Console.Write("Enter Storeid: ");
                order.Storeid = int.Parse(Console.ReadLine());
            
            //reading the quantity manually
             
                Console.Write("Enter quantity: ");
                order.Quantity = int.Parse(Console.ReadLine());

            //reading the Foodid manually

            Console.Write("Enter foodid: ");
               order.Foodid = int.Parse(Console.ReadLine());


            //reading the CustomerId manually

            Console.Write("Enter customerId: ");
            order.Customerid = int.Parse(Console.ReadLine());

            ordersBusinessLayer.AddOrders(order);
            Console.WriteLine("Orders Added Successfully.\n");
        }

        static void ViewOrders()
        {
            OrdersBusinessLayer ordersBusinessLayer = new OrdersBusinessLayer();
            List<Order> Od = ordersBusinessLayer.GetOrders();

            foreach (Order orders in Od)
            {
                Console.WriteLine(orders.Orderid + ", " +orders.OrderDate + "," + orders.Storeid + "," + orders.Foodid + ",");
            }
        }
        //updating Orderid
        static void UpdateOrderid()
        {
            try
            {
                OrdersBusinessLayer OrdersBusinessLayer = new OrdersBusinessLayer();
                Order orders = new Order();
                Console.Write("Enter Existing orderid: ");
                orders.Orderid = int.Parse(Console.ReadLine());

                //OrdersPresentation.UpdateOrders(orders);
                Console.WriteLine("orders Updated successfully.\n");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //updating storeid
        static void UpdateStoreid()
        {
            try
            {
                OrdersBusinessLayer ordersPresentation = new OrdersBusinessLayer();
                Order orders = new Order();
                Console.Write("Enter Existing storeid: ");
                orders.Storeid =int.Parse( Console.ReadLine());
                Console.Write("Enter New storeid: ");
                orders.Storeid = int.Parse(Console.ReadLine());

                //rdersPresentation.Updatestoreid(Orders);
                Console.WriteLine("storeid Updated successfully.\n");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

     

    }

}
