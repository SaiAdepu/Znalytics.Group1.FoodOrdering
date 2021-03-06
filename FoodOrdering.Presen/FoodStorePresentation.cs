﻿//using System;
//using System.Collections.Generic;
//using FoodOrdering.Entities;
//using FoodOrdering.BusinessLayer;

///// <summary>
///// Represents Login Information Of The FoodStore Details
///// </summary>
//namespace FoodOrdering.PresentationLayer
//{
//    class FoodStoreDetails
//    {
//        //Execution Starts From The Main Method
//        static void Main()
//        {
//            FoodStorePresentation();
//            Console.ReadKey();
//        }
//        //static method shares the same copy of method and its data
//        static void FoodStorePresentation()
//        {
//            int choice = 0;
//            //do while loop verifies the condition after execution of statements inside the loop
//            do
//            {
//                //displays foodstore menu
//                //display shown based on the option selected 
//                Console.WriteLine("FOODSTORE MENU");
//                Console.WriteLine("1. Add FoodStore");
//                Console.WriteLine("2. View FoodStore");
//                Console.WriteLine("3. Update StoreID");
//                Console.WriteLine("4. Update StoreName");
//                Console.WriteLine("5. Update Location");
//                Console.WriteLine("6. Update Phone");
//                Console.WriteLine("7. Update Email");
//                Console.WriteLine("8. Delete FoodStore");
//                Console.WriteLine("9. Exit");
//                Console.Write("Enter choice: ");
//                choice = int.Parse(Console.ReadLine());
//                //switch statement is a control mechanism which executes one case after another till the break statement appears.
//                switch (choice)
//                {
//                    case 1: AddFoodStore(); break;
//                    case 2: UpdateStoreName(); break;
//                    case 3: UpdateLocation(); break;
//                    case 4: UpdatePhone(); break;
//                    case 5: UpdateEmail(); break;
//                        //case 6: DeleteFoodStore();break; 

//                }
//            } while (choice != 8);//if none of the above methods
//        }

//        //adding customer details
//        static void AddFoodStore()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            FoodStore foodstore = new FoodStore();
//            try
//            {
//                //reading the storeid manually
//                Console.Write("Enter StoreID: ");
//                foodstore.StoreID = Console.ReadLine();
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {
//                //reading the storename manually
//                Console.Write("Enter StoreName: ");
//                foodstore.StoreName = Console.ReadLine();
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {  //reading the location manually
//                Console.Write("Enter Location: ");
//                foodstore.Location = Console.ReadLine();
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {   //reading the phone manually
//                Console.Write("Enter Phone: ");
//                foodstore.Phone = Console.ReadLine();
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            try
//            {  //reading the email manually
//                Console.Write("Enter Email: ");
//                foodstore.Email = Console.ReadLine();
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            foodstoreBusinessLayer.AddFoodStore(foodstore);
//            Console.WriteLine("FoodStore Added Successfully.\n");
//        }

//        static void Viewfoodstore()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            List<FoodStore> fs = foodstoreBusinessLayer.GetFoodStores();

//            foreach (FoodStore foodstore in fs)
//            {
//                Console.WriteLine(foodstore.StoreID + ", " + foodstore.StoreName + "," + foodstore.Location + "," + foodstore.Phone + "," + foodstore.Email + "," );
//            }
//        }
//        //updating storename
//        static void UpdateStoreName()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            FoodStore foodstore = new FoodStore();
//            Console.Write("Enter Existing StoreID: ");
//            foodstore.StoreID = Console.ReadLine();
//            Console.Write("Enter New CustomerName: ");
//            foodstore.StoreName = Console.ReadLine();

//            foodstoreBusinessLayer.UpdateStoreName(foodstore);
//            Console.WriteLine("StoreName Updated successfully.\n");
//        }
//        //updating Location
//        static void UpdateLocation()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            FoodStore foodstore = new FoodStore();
//            Console.Write("Enter Existing StoreID: ");
//            foodstore.StoreID = Console.ReadLine();
//            Console.Write("Enter New Location: ");
//            foodstore.Location = Console.ReadLine();

//            foodstoreBusinessLayer.UpdateLocation(foodstore);
//            Console.WriteLine("Location Updated successfully.\n");
//        }
//        //updating phone
//        static void UpdatePhone()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            FoodStore foodstore = new FoodStore();
//            Console.Write("Enter Existing StoreID: ");
//            foodstore.StoreID = Console.ReadLine();
//            Console.Write("Enter New Phone: ");
//            foodstore.Phone = Console.ReadLine();

//            foodstoreBusinessLayer.UpdatePhone(foodstore);
//            Console.WriteLine("Phone Updated successfully.\n");
//        }
//        //updating email
//        static void UpdateEmail()
//        {
//            FoodStoreBusinessLayer foodstoreBusinessLayer = new FoodStoreBusinessLayer();
//            FoodStore foodstore = new FoodStore();
//            Console.Write("Enter Existing CustomerID: ");
//            foodstore.StoreID = Console.ReadLine();
//            Console.Write("Enter New CustomerAddress: ");
//            foodstore.Email = Console.ReadLine();

//            foodstoreBusinessLayer.UpdateEmail(foodstore);
//            Console.WriteLine("Email Updated successfully.\n");
//        }



//    }
//}