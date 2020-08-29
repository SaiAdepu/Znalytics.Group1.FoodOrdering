using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;
using Znalytics.Grp1.FoodOrdering.Businesslayer;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    //Menu of Food
    class FoodTypeMenu
    {
        //Displays type of Food Menu
        public void DisplayMenu()
        {
            int choice=0;
            do {
                Console.WriteLine("1.Cool Drinks\n2.Ice Creams\n3.Non-Veg\n4.Veg\n5.View Food Items\n6.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CooldrinksMenu cm = new CooldrinksMenu();
                        cm.CoolDrinkOperation();
                        break;
                    case 5: FoodItemDisplay();break;


                }
            } while (choice!=6);
            
        }
        //Dispalys Stored Food items
        public void FoodItemDisplay()
        {
            AddFoodItemBL afi = new AddFoodItemBL();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("FoodId\tFoodType\tFoodName\tFoodPrice\tFoodQuantity");
            foreach (FoodItem item in listFoodItems)
            { 
                Console.WriteLine(item.FoodId+"\t" +item.FoodType+ "\t" + item.FoodName+ "\t" + item.Price+ "\t" + item.Quantity);
            }
            Console.WriteLine("**************************************************************************************");
        }
    }

}
