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
            FoodStorePresentation();
            Console.ReadKey();
        }

        static void FoodStorePresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Food Store MENU");
                Console.WriteLine("1. Add FoodStore");
                Console.WriteLine("2. View FoodStore");
                Console.WriteLine("3. Update FoodStore");
                Console.WriteLine("4. Delete FoodStore");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddFoodStore(); break;
                    case 2: ViewFoodStore(); break;
                    case 3: UpdateFoodStore(); break;
                    case 4: DeleteFoodStore(); break;

                }
            } while (choice != 5);
        }

        static void AddFoodStore()
        {
            FoodStoreBusinessLogic foodstoreBusinessLogic = new FoodStoreBusinessLogic();
            FoodStore foodstore = new FoodStore();

            Console.Write("Enter StoreID: ");
            foodstore.StoreID = Console.ReadLine();
            Console.Write("Enter  StoreName: ");
            foodstore.StoreName = Console.ReadLine();
            Console.Write("Enter Location: ");
            foodstore.Location = Console.ReadLine();
            Console.Write("Enter Phone: ");
            foodstore.Phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            foodstore.Email = Console.ReadLine();
            Console.Write("Enter Rating: ");
            foodstore.Rating = Console.ReadLine();

            foodstoreBusinessLayer.Add(foodstore);
            Console.WriteLine("FoodStore Added Successfully \n ");
        }

        static void Viewfoodstores()
        {
            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
            List<foodstore> fs = foodstoreBusinessLayer.GetFoodStore();

            foreach (foodstore fs in fs)
            {
                Console.WriteLine(fs.StoreID + ", " + fs.StoreName + "," + fs.Location + "," +fs.Phone + "," + fs.Email + "," +fs.Rating+",");
            }
        }

        static void UpdateFoodStore()
        {
            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
            FoodStore fs = new FoodStore();
            Console.Write("Enter Existing StoreID: ");
            foodstore.StoreID = Console.ReadLine();
            Console.Write("Enter New StoreName: ");
            foodstore.StoreName = Console.ReadLine();
           
            foodstoreBusinessLayer.UpdateFoodStore(foodstore);
            Console.WriteLine("FoodStore Updated successfully.\n");
        }
    }
}