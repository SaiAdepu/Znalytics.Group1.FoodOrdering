class Program11
{
    static void Main()
    {
        Employeelogin f = new Employeelogin();

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
        System.Console.WriteLine("enter the Name:" +f.LastName );

        System.Console.WriteLine("enter the Password");
        f.Password = (System.Console.ReadLine());
        System.Console.WriteLine(f.Password);

        System.Console.WriteLine("enter the ConfirmPassword");
        f.ConfirmPassword = (System.Console.ReadLine());
        System.Console.WriteLine(f.ConfirmPassword); ;

        System.Console.WriteLine("enter the MobileNumber");
        f.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
        System.Console.WriteLine(f.MobileNumber);

        System.Console.WriteLine("enter the Food storeid ");
        f.FoodStoreID = (System.Console.ReadLine());
        System.Console.WriteLine(f.FoodStoreID);
    }
}
