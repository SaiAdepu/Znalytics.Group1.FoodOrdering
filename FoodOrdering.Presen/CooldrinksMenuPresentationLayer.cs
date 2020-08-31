using System;
using FoodOrdering.Entities;
using FoodOrdering.BusinessLayer;
using System.Collections.Generic;
using System.IO;

namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Perform operation on Cooldrinks
    /// </summary>
    public class CooldrinksMenuPresentationLayer
    {

        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
        /// <summary>
        /// Perform list operation on Cooldrinks
        /// </summary>
        public void CoolDrinkOperation()
        {
            int choice, choiceOut;
            bool choiceBool;
            do
            {
            a:
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add CoolDrink");
                Console.WriteLine("2.Delete CoolDrink");
                Console.WriteLine("3.Update CoolDrink Quantity");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice: ");
                choiceBool = int.TryParse(Console.ReadLine(), out choiceOut);
                if (!choiceBool)
                {
                    Console.WriteLine("\n****** Invalid Choice *******\n");
                    goto a;
                }
                choice = choiceOut;
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

            } while (choice != 0);
        }


        /// <summary>
        /// Adding CoolDrinks details
        /// </summary>
        public void AddCoolDrink()
        {
            int choiceOut1, choiceOut2;
            try
            {
                FoodItem fi = new FoodItem();
                //  Auto incerementd serial Number initilises here as Food Id
                fi.FoodId = ++FoodItem.CoolDrinkIdCount;

                fi.FoodType = "Cooldrink";

                Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Name:");
                fi.FoodName = Console.ReadLine();
            a:
                Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Price:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut1);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                fi.Price = choiceOut1;

            b:
                Console.Write("Enter Cool Drink Id: " + fi.FoodId + " Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceOut2);
                if (!choice2)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto b;
                }
                fi.Quantity = choiceOut2;

                afi.AddFood(fi);
                Console.WriteLine("\n////////// Food Item Added Successfully //////////");
            }
            catch (Exception ex)
            {
                --FoodItem.CoolDrinkIdCount;
                Console.WriteLine(ex.Message);
            }
        }




        /// <summary>
        /// Remove the Food item based on food Id
        /// </summary>
        public void RemoveCoolDrink()
        {
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> removeCoolDrink = listFoodItems.FindAll(item => item.FoodId >= 1 && item.FoodId <= 100);
                if (removeCoolDrink.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                removeCoolDrink.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in removeCoolDrink)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");


                bool temp;
                int tempId;
                FoodItem fi = new FoodItem();
            a:
                Console.Write("Enter Existing Cooldtrink Id to remove OR 0 to Exit:");
                temp = int.TryParse(Console.ReadLine(), out tempId);
                if (!temp)
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }
                if (tempId == 0)
                    return;
                if (tempId >= 1 && tempId <= 100)
                {
                    fi.FoodId = tempId;
                    fi.FoodType = "Cooldrink";
                    afi.RemoveFoodItem(fi);
                    Console.WriteLine("\n////////// Food Item Deleted Successfully //////////");
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
        ///updates Food Quantity based on Food Id 
        /// </summary>
        public void UdateCoolDrink()
        {
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> updateCoolDrink = listFoodItems.FindAll(item => item.FoodId >= 1 && item.FoodId <= 100);
               //Checking list is empty or not
                if (updateCoolDrink.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                updateCoolDrink.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in updateCoolDrink)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");

                bool temp1, temp2;
                int tempId, tempQuantity;
                FoodItem fi = new FoodItem();
            a:
                Console.Write("Enter Existing Cooldtrink Id to update OR 0 to Exit:");
                temp1 = int.TryParse(Console.ReadLine(), out tempId);
                if (!temp1)
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }
                //if Id equals 0 stop method Execution
                if (tempId == 0)
                    return;

                //Check id is in between 1 and 100 to add in cooldrinks type
                if (tempId >= 1 && tempId <= 100)
                {
                    fi.FoodId = tempId;
                    Console.WriteLine("\n////////// Food Item Updated Successfully //////////");
                }
                else
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }
                
            b:
                Console.Write("Enter Quantity:");
                temp2 = int.TryParse(Console.ReadLine(), out tempQuantity);
                if (!temp2)
                {
                    Console.WriteLine("\n****** Invalid Quantity ******\n");
                    goto b;
                }
                fi.Quantity = tempQuantity;
                afi.UpdateFoodItem(fi);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
