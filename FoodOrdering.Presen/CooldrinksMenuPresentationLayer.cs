using System;
using FoodOrdering.Entities;
using FoodOrdering.BusinessLayer;

namespace HootelStoreFooditems
{
    class CooldrinksMenuPresentationLayer
    {

        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
        /// <summary>
        /// Perform operation on Cooldrinks
        /// </summary>
        public void CoolDrinkOperation()
        {
            int choice;
            do
            {
                Console.WriteLine("-------------------------------------------");
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
                        UdateCoolDrink();
                        break;
                }
                //  Console.WriteLine("****** Invalid Choice ******");
            } while (choice != 4);


        }
        /// <summary>
        /// Adding CoolDrinks details
        /// </summary>
        public void AddCoolDrink()
        {
            FoodItem fi = new FoodItem();
            //  Auto incerementd serial Number initilises here as Food Id
            fi.FoodId = ++FoodItem.foodIdCount;

            fi.FoodType = "Cooldrink";

            Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Name:");
            fi.FoodName = Console.ReadLine();

            Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());

            afi.AddFood(fi);

        }
        //receving food item id to remove
        public void RemoveCoolDrink()
        {
            bool temp;
            int tempId;
            FoodItem fi = new FoodItem();
        a:
            Console.Write("Enter Existing Cooldtrink Id to remove:");
            temp = int.TryParse(Console.ReadLine(), out tempId);
            if (!temp)
            {
                Console.WriteLine("\n****** Invalid Id ******");
                goto a;
            }
            fi.FoodId = tempId;
            fi.FoodType = "Cooldrink";
            afi.RemoveFoodItem(fi);

        }
        public void UdateCoolDrink()
        {
            bool temp1, temp2;
            int tempId, tempQuantity;
            FoodItem fi = new FoodItem();
        a:
            Console.Write("Enter Existing Cooldtrink Id to update:");
            temp1 = int.TryParse(Console.ReadLine(), out tempId);
            if (!temp1)
            {
                Console.WriteLine("\n****** Invalid Id ******");
                goto a;
            }
            fi.FoodId = tempId;
        b:
            Console.Write("Enter Quantity:");
            temp2 = int.TryParse(Console.ReadLine(), out tempQuantity);
            if (!temp2)
            {
                Console.WriteLine("\n****** Invalid Quantity ******");
                goto b;
            }
            fi.Quantity = tempQuantity;
            afi.UpdateFoofItem(fi);
        }

    }
}
