using System;

class Customerpresentationlayer
{
    static void Main()
    {
        Customer c = new Customer();
        System.Console.WriteLine("------Customer Details------");
        System.Console.Write("Enter CustomerName:");
        c.CustomerName = System.Console.ReadLine();
        System.Console.Write("Enter CustomerId:");
        c.CustomerId = int.Parse(System.Console.ReadLine());
        System.Console.Write("Enter CustomerEmail:");
        c.CustomerEmail = System.Console.ReadLine();
        System.Console.Write("Enter CustomerPhoneNumber:");
        c.CustomerPhoneNumber = System.Console.ReadLine();
        System.Console.Write("Enter CustomerAdress:");
        c.CustomerAddress = System.Console.ReadLine();
        //System.Console.ReadKey();
        System.Console.WriteLine("-----The customer details are---------");
        System.Console.WriteLine("customername:" + c.CustomerName);
        System.Console.WriteLine("customerId :" + c.CustomerId);
        System.Console.WriteLine("customerEmail:" + c.CustomerEmail);
        System.Console.WriteLine("customerphonenumber:" + c.CustomerPhoneNumber);
        System.Console.WriteLine("customerAddress:" + c.CustomerAddress);
        System.Console.WriteLine("------Registration Successful---------");
        System.Console.ReadKey();
    }
}

