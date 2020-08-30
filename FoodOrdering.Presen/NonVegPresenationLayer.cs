using FoodOrdering.BusinessLayer;
using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.PresentationLayer
{
    /// <summary>
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
            int choice, choiceout;
            bool choiceBool;
            do
            {
            a:
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add NonVeg");
                Console.WriteLine("2.Delete NonVeg");
                Console.WriteLine("3.Update NonVeg Quantity");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice: ");
                choiceBool = int.TryParse(Console.ReadLine(), out choiceout);
                if (!choiceBool)
                {
                    Console.WriteLine("\n****** Invalid Choice ******\n");
                    goto a;
                }
                choice = choiceout;
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

                }
            } while (choice != 0);

        }


        /// <summary>
        /// Adding NonVeg Food details
        /// </summary>
        public void AddNonVeg()
        {
            int choiceOut1, choiceOut2;
            try
            {
                FoodItem fi = new FoodItem();
                //  Auto incerementd serial Number initilises here as Food Id
                fi.FoodId = ++FoodItem.NonVegIdCount;

                fi.FoodType = "NonVeg";

                Console.Write("Enter NonVeg Id: " + fi.FoodId + " Name:");
                fi.FoodName = Console.ReadLine();
            a:
                Console.Write("Enter NonVeg Id: " + fi.FoodId + " Price:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut1);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                fi.Price = choiceOut1;

            b:
                Console.Write("Enter NonVeg Id: " + fi.FoodId + " Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceOut2);
                if (!choice2)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto b;
                }
                fi.Quantity = choiceOut2;

                afi.AddFood(fi);
                Console.WriteLine("\n////////// Food Item Added Sucessfully //////////");
            }
            catch (Exception ex)
            {
                --FoodItem.NonVegIdCount;
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>
        public void RemoveNonVeg()
        {
            int choiceout;
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> nonVeg = listFoodItems.FindAll(item => item.FoodId >= 301 && item.FoodId <= 400);
                if (nonVeg.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                nonVeg.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in nonVeg)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");

                FoodItem fi = new FoodItem();
            a:
                Console.WriteLine("Enter Existing NonVeg Id to remove OR 0 to Exit:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceout);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                if (choiceout == 0)
                    return;
                if (choiceout >= 301 && choiceout <= 400)
                {

                    fi.FoodId = choiceout;
                fi.FoodType = "NonVeg";
                afi.RemoveFoodItem(fi);
                Console.WriteLine("\n////////// Food Item Deleted Sucessfully //////////");
                }
                else
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Updates the food Item Based on food Id
        /// </summary>

        public void UdateNonVeg()
        {
            int choiceOut1, choiceout2;
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> nonVeg = listFoodItems.FindAll(item => item.FoodId >= 301 && item.FoodId <= 400);
                if (nonVeg.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                nonVeg.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in nonVeg)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");

                FoodItem fi = new FoodItem();
            a:
                Console.Write("Enter Existing NonVeg Id to update OR 0 to Exit:");
                bool choice1 = int.TryParse(Console.ReadLine(), out choiceOut1);
                if (!choice1)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                if (choiceOut1 == 0)
                    return;
                if (choiceOut1 >= 301 && choiceOut1 <= 400)
                {
                    fi.FoodId = choiceOut1;
                }
                else
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }

                
            b:
                Console.Write("Enter NonVeg Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceout2);
                if (!choice2)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto b;
                }
                fi.Quantity = choiceout2;
                afi.UpdateFoodItem(fi);
                Console.WriteLine("\n////////// Food Item Updated Sucessfully //////////");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
