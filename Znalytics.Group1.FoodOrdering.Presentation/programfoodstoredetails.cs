using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Grp1.FoodOrdering.Businesslayer;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    class foodstoredetails
    {
        static void Main()

        {
            foodstoredetails foodstoredetails = new foodstoredetails();

            System.Console.WriteLine("Enter store id");
            int storeID = int.Parse(System.Console.ReadLine());
           System.Console.WriteLine("Enter store name");
            string storeName = System.Console.ReadLine();
            System.Console.WriteLine("Enter location:");
            string location = System.Console.ReadLine();
           System.Console.WriteLine("enter phone");
            int phone = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter email");
            string email = System.Console.ReadLine();
           System.Console.WriteLine("enter rating");
           int rating = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(foodstoredetails.StoreID);
            System.Console.WriteLine(foodstoredetails.StoreName); 
            System.Console.WriteLine(foodstoredetails.Location);   
            System.Console.WriteLine(foodstoredetails.Phone);
            System.Console.WriteLine(foodstoredetails.Emaill);
           System.Console.WriteLine(foodstoredetails.Rating);
           System.Console.ReadKey();
        }
    }
}
