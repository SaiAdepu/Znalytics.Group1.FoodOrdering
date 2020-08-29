using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group1.FoodOrdering.Entities;
using Znalytics.Grp1.FoodOrdering.Businesslayer;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    //Dsipalys cooldrink Menu
    public class CooldrinksMenu
    {
        FoodItem fi = new FoodItem();
        AddFoodItemBL afi = new AddFoodItemBL();
        /// <summary>
        /// Perform operation on Cooldrinks
        /// </summary>
        public void CoolDrinkOperation()
        {
            int choice;
            do
            {
                Console.WriteLine("1.Add CoolDrink");
                Console.WriteLine("2.Delete CoolDrink");
                Console.WriteLine("3.Update CoolDrink Quantity");
                Console.WriteLine("4.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddCoolDrink();
                        break;
                    case 2:
                        RemoveCoolDrink();
                        break;
                    case 3:
                        break;
                }
            } while (choice!=4);
        

        }
        /// <summary>
        /// Adding CoolDrinks details
        /// </summary>
        public void AddCoolDrink()
        {
            Console.WriteLine("Enter Cool Drink Id:");
            fi.FoodId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Food Type:");
            fi.FoodType = "Cooldrink";

            Console.WriteLine("Enter Cool Drink Name:");
            fi.FoodName = Console.ReadLine();

            Console.WriteLine("Enter Cool Drink Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cool Drink Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());

           
            afi.AddFood(fi);

        }
        //receving food item id to remove
        public void RemoveCoolDrink()
        {
            Console.WriteLine("Enter Existing Cooldtrink Id to remove:");
            fi.FoodId = int.Parse(Console.ReadLine());
            fi.FoodType = "Cooldrink";
            afi.RemoveFoodItem(fi);

        }


    }
}
