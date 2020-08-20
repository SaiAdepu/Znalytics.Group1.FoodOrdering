using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;
using Znalytics.Grp1.FoodOrdering.Businesslayer;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    class FoodTypeMenu
    {
        //static void main() {
        //    FoodTypeMenu t = new FoodTypeMenu();
        //    t.DisplayMenu();
        //}

        public void DisplayMenu()
        {
            Console.WriteLine("1.Cool Drinks\n2.Ice Creams\n3.Non-Veg\n4.Veg");
            Console.Write("Enter Choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CooldrinksMenu cm = new CooldrinksMenu();
                    cm.AddCoolDrink();
                    break;

            }
            FoodItemDisplay();
        }
        public void FoodItemDisplay()
        {
            AddFoodItem afi = new AddFoodItem();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();
            foreach (FoodItem item in listFoodItems)
            {
                Console.WriteLine(item.FoodId);
                Console.WriteLine(item.FoodType);
                Console.WriteLine(item.FoodName);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Quantity);

            }
        }
    }

}
