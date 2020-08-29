using FoodOrdering.BusinessLayer;
using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Presen
{/// <summary>
 /// Performs the operations on Veg Food Items
 /// </summary>
    internal class VegPresenationlayer
    {
        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();

        /// <summary>
        /// represents the list of operation on Veg
        /// </summary>
        public void VegOperation()
        {
            // step1:
            int choice;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add Veg");
                Console.WriteLine("2.Delete Veg");
                Console.WriteLine("3.Update Veg Quantity");
                Console.WriteLine("4.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddVeg();
                        break;
                    case 2:
                        RemoveVeg();
                        break;
                    case 3:
                        UdateVeg();
                        break;


                }
            } while (choice != 4);


        }


        /// <summary>
        /// Adding Veg Food details
        /// </summary>
        public void AddVeg()
        {
            FoodItem fi = new FoodItem();
            //  Auto incerementd serial Number initilises here as Food Id
            fi.FoodId = ++FoodItem.foodIdCount;

            fi.FoodType = "Veg";

            Console.Write("Enter Veg Id: " + fi.FoodId + " Name:");
            fi.FoodName = Console.ReadLine();

            Console.Write("Enter Veg Id: " + fi.FoodId + " Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter Veg Id: " + fi.FoodId + " Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());
            afi.AddFood(fi);

        }


        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>
        public void RemoveVeg()
        {
            FoodItem fi = new FoodItem();
            Console.WriteLine("Enter Existing Veg Id to remove:");
            fi.FoodId = int.Parse(Console.ReadLine());
            fi.FoodType = "Veg";
            afi.RemoveFoodItem(fi);

        }


        /// <summary>
        /// Updates the food Item Based on food Id
        /// </summary>
        public void UdateVeg()
        {
            FoodItem fi = new FoodItem();
            Console.Write("Enter Existing Veg Id to update:");
            fi.FoodId = int.Parse(Console.ReadLine());
            Console.Write("Enter Veg Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());
            afi.UpdateFoofItem(fi);
        }
    }
}
