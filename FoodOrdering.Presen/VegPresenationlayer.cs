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
    /// Performs the operations on Veg Food Items
    /// </summary>
    public class VegPresenationlayer
    {
        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();

        /// <summary>
        /// represents the list of operation on Veg
        /// </summary>
        public void VegOperation()
        {
            // step1:
            int choice, choiceOut;
            bool choiceBool;
            do
            {
            a:
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add Veg");
                Console.WriteLine("2.Delete Veg");
                Console.WriteLine("3.Update Veg Quantity");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice: ");
                choiceBool = int.TryParse(Console.ReadLine(), out choiceOut);
                if (!choiceBool)
                {
                    Console.WriteLine("\n***** Invalid Choice ******\n");
                    goto a;
                }
                choice = choiceOut;
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
            } while (choice != 0);


        }


        /// <summary>
        /// Adding Veg Food details
        /// </summary>
        public void AddVeg()
        {
            int choiceOut1, choiceOut2;
            try
            {
                FoodItem fi = new FoodItem();
                //  Auto incerementd serial Number initilises here as Food Id
                fi.FoodId = ++FoodItem.VegIdCount;

                fi.FoodType = "Veg";

                Console.Write("Enter Veg Id: " + fi.FoodId + " Name:");
                fi.FoodName = Console.ReadLine();
            a:
                Console.Write("Enter Veg Id: " + fi.FoodId + " Price:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut1);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                fi.Price = choiceOut1;
            b:
                Console.Write("Enter Veg Id: " + fi.FoodId + " Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceOut2);
                if (!choice2)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto b;
                }
                afi.AddFood(fi);
                Console.WriteLine("\n////////// Food Item Added Successfully //////////");
            }
            catch (Exception ex)
            {
                --FoodItem.VegIdCount;
                Console.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>
        public void RemoveVeg()
        {

            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> nonVeg = listFoodItems.FindAll(item => item.FoodId >= 201 && item.FoodId <= 300);
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


                int choiceOut;
                FoodItem fi = new FoodItem();
            a:
                Console.WriteLine("Enter Existing Veg Id to remove OR 0 to Exit:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter digits only *******\n");
                    goto a;
                }
                if (choiceOut == 0)
                    return;
                if (choiceOut >= 201 && choiceOut <= 300)
                {
                    fi.FoodId = choiceOut;
                    fi.FoodType = "Veg";
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
        /// Updates the food Item Based on food Id
        /// </summary>
        public void UdateVeg()
        {
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> nonVeg = listFoodItems.FindAll(item => item.FoodId >= 201 && item.FoodId <= 300);
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

                int choiceOut, choiceOut2;
                FoodItem fi = new FoodItem();
            a:
                Console.Write("Enter Existing Veg Id to update OR 0 to Exit:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter digits only *******\n");
                    goto a;
                }
                if (choiceOut == 0)
                    return;
                if (choiceOut >= 201 && choiceOut <= 300)
                {
                    fi.FoodId = choiceOut;
                }
                else
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }

            b:
                Console.Write("Enter Veg Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceOut2);
                if (choice2)
                {
                    Console.WriteLine("\n****** Enter Digits only ********\n");
                    goto b;
                }
                fi.Quantity = choiceOut2;
                afi.UpdateFoodItem(fi);
                Console.WriteLine("\n////////// Food Item Updated Successfully //////////");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
