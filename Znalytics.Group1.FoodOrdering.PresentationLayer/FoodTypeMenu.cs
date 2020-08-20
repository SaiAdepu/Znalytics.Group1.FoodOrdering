using System;
namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    class FoodTypeMenu
    {
        static void main() {
            FoodTypeMenu t = new FoodTypeMenu();
            t.DisplayMenu();
        }

        void DisplayMenu()
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

        }
    }

}
