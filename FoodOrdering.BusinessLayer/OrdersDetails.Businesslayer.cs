using System.Collections.Generic;
using OrdersDetails.BusinessLayer;
using OrdersDetail.Entities;

namespace OrdersDetails;
{
    class Program
{
    static void Main()
    {
        OrdersDetails.Businessslayer();
        Console.ReadKey();
    }

    static void OrdersDetails.Businessslayer()
    {
        int choice = 0;
        do
        {
            System.Console.WriteLine("OrdersDetails");
            System Console.WriteLine("1. Add OrdersDetails);

            System.Console.WriteLine("2. View OrdersDetails");
            System.Console.WriteLine("3. Update OrdersDetails");
            System.Console.WriteLine("4. Delete OrdersDetails");
            System.Console.WriteLine("5. Exit");
            System.Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Add OrdersDetails(); break;
                case 2: View OrdersDetails(); break;
                case 3: Update OrdersDetails(); break;
                case 4: Delete OrdersDetails(); break;


            }
        } while (choice != 5);
    }

    static void OrdersDetails()
    {
        OrdersDetails.Businesslayer ordersDetails.Businesslayer = new OrdersDetails.Businesslayer();
        OrdersDetails ordersDetails = new OrdersDetails();

        System.Console.Writeline("Enter Orderid: ");
        OrdersDetails.Orderid = Console.ReadLine();

        System Console.Writeline("Enter  OrderDate: ");
        OrdersDetails.OrderDate = Console.ReadLine();

        System Console.Writeline("Enter Userid: ");
        OrdersDetails.Userid = Console.ReadLine();

        System.Console.Writeline("Enter Storeid: ");
        OrdersDetails.Storeid = Console.ReadLine();

        System.Console.Writeline("Enter Employeeid: ");
        OrdersDetails.Employeeid = Console.ReadLine();

        System.Console.Writeline("Enter Foodid: ");
        OrdersDetails.Foodid = Console.ReadLine();

        OrdersDetails.sBusinesslayer.Add(OrdersDetails);
        System.Console.WriteLine("OrdersDetails Added Successfully.\n");
    }

    static void ViewOrdersDetails()
    {
        OrdersDetails.Businesslayer ordersDetails.Businesslayer = new OrdersDetails.Businesslayer();
        List<OrdersDetails> od = OrdersDetails.Businesslayer Get.OrdersDetails();

        foreach (OrdersDetails od in od)
        {
            System.Console.WriteLine(od.Orderid + ", " + od.OrderDate + "," + od.Userid + "," + od.Storeid + "," + od.Employeeid + "," + od.Foodid + ",");
        }
    }

    static void UpdateOrdersDetails()
    {
        OrdersDetails.Businesslayer OrdersDetails.Businesslayer = new OrdersDetails.Businesslayer();
        OrdersDetails od = new OrdersDetails();
        System.Console.Writeline("Enter Existing Orderid: ");
        OrdersDetails.Orderid = Console.ReadLine();

        OrdersDetails.Businesslayer.UpdateOrdersDetails(OrdersDetails);
        System.Console.WriteLine("OrdersDetails Updated successfully.\n");
    }
}
}
