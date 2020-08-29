using FoodOrdering.BusinessLayer;
using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Presen
{
    class IcecreamPresentationLayer
    {
        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();


        /// <summary>
        /// represents the list of operation on Icecreams
        /// </summary>
        public void IcecreamOperation()
        {
            //  step1:
            int choice;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add Icecream");
                Console.WriteLine("2.Delete Icecream");
                Console.WriteLine("3.Update Icecream Quantity");
                Console.WriteLine("4.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddIcecream();
                        break;
                    case 2:
                        RemoveIcecream();
                        break;
                    case 3:
                        UdateIcecream();
                        break;
                        //default :
                        //Console.WriteLine("****************Invalid Choice****************");
                        //goto step1;
                        //break;

                }
            } while (choice != 4);


        }
        /// <summary>
        /// Adding Icecream Food details
        /// </summary>
        public void AddIcecream()
        {


            FoodItem fi = new FoodItem();
            //  Auto incerementd serial Number initilises here as Food Id
            fi.FoodId = ++FoodItem.foodIdCount;

            fi.FoodType = "Icecream";

            Console.Write("Enter Icecream Id: " + fi.FoodId + " Name:");
            fi.FoodName = Console.ReadLine();

            Console.Write("Enter Icecream Id: " + fi.FoodId + " Price:");
            fi.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter Icecream Id: " + fi.FoodId + " Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());



            afi.AddFood(fi);

        }
        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>

        public void RemoveIcecream()
        {
            FoodItem fi = new FoodItem();
            Console.WriteLine("Enter Existing Icecream Id to remove:");
            fi.FoodId = int.Parse(Console.ReadLine());
            fi.FoodType = "Icecream";
            afi.RemoveFoodItem(fi);

        }


        /// <summary>
        /// Updates the food Item Based on food Id
        /// </summary>

        public void UdateIcecream()
        {
            FoodItem fi = new FoodItem();
            Console.Write("Enter Existing Icecream Id to update:");
            fi.FoodId = int.Parse(Console.ReadLine());
            Console.Write("Enter Icecream Quantity:");
            fi.Quantity = int.Parse(Console.ReadLine());
            afi.UpdateFoofItem(fi);
        }
    }
}
