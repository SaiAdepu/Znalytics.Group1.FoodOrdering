using FoodOrdering.BusinessLayer;
using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Presen
{/// <summary>
 /// Performs the operations on Non Veg Food Items
 /// </summary>
    public class NonVegPresenationLayer
    {

        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
        /// <summary>
        /// represents the list of operation on Non     Veg
        /// </summary>
        public void NonVegOperation()
        {
            //step1:
            int choice;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add NonVeg");
                Console.WriteLine("2.Delete NonVeg");
                Console.WriteLine("3.Update NonVeg Quantity");
                Console.WriteLine("4.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddNonVeg();
                        break;
                    case 2:
                        RemoveNonVeg();
                        break;
                    case 3:
                        UdateNonVeg();
                        break;
                        //default :
                        //Console.WriteLine("****************Invalid Choice****************");
                        //goto step1;
                        //break;

                }
            } while (choice != 4);

        }


        /// <summary>
        /// Adding NonVeg Food details
        /// </summary>
        public void AddNonVeg()
        {


            FoodItem fi = new FoodItem();
            //  Auto incerementd serial Number initilises here as Food Id
            fi.FoodId = ++FoodItem.foodIdCount;

            fi.FoodType = "NonVeg";

            Console.Write("Enter NonVeg Id: " + fi.FoodId + " Name:");
            fi.FoodName = Console.ReadLine();

            Console.Write("Enter NonVeg Id: " + fi.FoodId + " Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter NonVeg Id: " + fi.FoodId + " Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());

            afi.AddFood(fi);

        }
        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>
        public void RemoveNonVeg()
        {
            FoodItem fi = new FoodItem();
            Console.WriteLine("Enter Existing NonVeg Id to remove:");
            fi.FoodId = int.Parse(Console.ReadLine());
            fi.FoodType = "NonVeg";
            afi.RemoveFoodItem(fi);

        }
        /// <summary>
        /// Updates the food Item Based on food Id
        /// </summary>

        public void UdateNonVeg()
        {
            FoodItem fi = new FoodItem();
            Console.Write("Enter Existing NonVeg Id to update:");
            fi.FoodId = int.Parse(Console.ReadLine());
            Console.Write("Enter NonVeg Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());
            afi.UpdateFoofItem(fi);
        }
    }
}
