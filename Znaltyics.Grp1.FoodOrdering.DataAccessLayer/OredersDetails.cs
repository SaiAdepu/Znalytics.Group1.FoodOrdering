

class OnlineFoodOrderSystem
{

    static void Main()
    {
        OrederDetails od = new OrederDetails();

        System.Console.WriteLine("enter the Orderid");
        System.Console.WriteLine(od.Orderid);

        System.Console.WriteLine("enter OrederDate");
        System.Console.WriteLine("The Date Only is " + DateTime.Now);

        System.Console.WriteLine("enter the Userid");
        System.Console.WriteLine(od.Userid);

        System.Console.WriteLine("enter the storeid ");
        System.Console.WriteLine(od.Storeid);

        System.Console.WriteLine("enter the employeeid");
        od.Employeeid = (System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine(od.Employeeid);

        System.Console.WriteLine("enter the Foodid");
        od.Foodid = (System.Console.ReadLine());
        System.Console.WriteLine(od.Foodid);

        System.Console.WriteLine("enter the Price");
        System.Console.WriteLine(od.Price);

        System.Console.WriteLine("enter the qty");
        od.qty = (System.Console.ReadLine());
        System.Console.WriteLine(od.qty);

        System.Console.WriteLine("enter the Totalamount");
        od.Totalamount = (System.Console.ReadLine());
        System.Console.WriteLine(od.Totalamount);

        System.Console.ReadKey();



    }
}