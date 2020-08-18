class programfoodstoredetails
{
    static void Main()

    {
        FoodStoreDetails foodstoredetails = new FoodStoreDetails();

        System.Console.WriteLine("Enter store id");
        int storeID = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Enter store name");
        string storeName = System.Console.ReadLine();
        System.Console.WriteLine("Enter phone:");
        string phone = System.Console.ReadLine();
        System.Console.WriteLine("enter location");
        string location = System.Console.ReadLine();
        System.Console.WriteLine("enter rating");
        int rating = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine(foodstoredetails.storeID);
        System.Console.WriteLine(foodstoredetails.StoreName); //get method will be called
        System.Console.WriteLine(foodstoredetails.Phone);   //get method will be called
        System.Console.WriteLine(foodstoredetails.Location);
        System.Console.WriteLine(foodstoredetails.Rating);
        System.Console.ReadKey();
    }
}



