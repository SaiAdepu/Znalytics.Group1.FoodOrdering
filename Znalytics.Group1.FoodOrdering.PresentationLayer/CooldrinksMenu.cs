using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group1.FoodOrdering.Entities;
using Znalytics.Grp1.FoodOrdering.Businesslayer;

namespace Znalytics.Group1.FoodOrdering.PresentationLayer
{
    public class CooldrinksMenu
    {
        FoodItem fi = new FoodItem();
        /// <summary>
        /// Perform operation on Cooldrinks
        /// </summary>
        public void Operations()
        {
            Console.WriteLine("1.Add CoolDrinks");
            Console.WriteLine("2.Delete CoolDrinks");
            Console.WriteLine("3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddCoolDrink();
                    break;
            }

        }
        /// <summary>
        /// Adding CoolDrinks
        /// </summary>
        public void AddCoolDrink()
        {
            Console.WriteLine("Enter CooldtrinkId:");
            fi.FoodId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Food Type:");
            fi.FoodType = "Cooldrink";

            Console.WriteLine("Enter Cooldtrik Name:");
            fi.FoodName = Console.ReadLine();

            Console.WriteLine("Enter Cooldtrink Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cooldtrink Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());

            AddFoodItem afi = new AddFoodItem();
            afi.AddFood(fi);

        }
    }
}
