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
    /// Perform operation on Icecreams
    /// </summary>
    public class IcecreamPresentationLayer
    {
        AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();


        /// <summary>
        /// represents the list of operation on Icecreams
        /// </summary>
        public void IcecreamOperation()
        {
            //  step1:
            int choice, choiceOut;
            bool choiceBool;
            do
            {
            a:
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.Add Icecream");
                Console.WriteLine("2.Delete Icecream");
                Console.WriteLine("3.Update Icecream Quantity");
                Console.WriteLine("0.Exit");
                Console.Write("Enter choice: ");
                choiceBool = int.TryParse(Console.ReadLine(), out choiceOut);
                if (!choiceBool)
                {
                    Console.WriteLine("\n****** Invalid Choice ******\n");
                    goto a;
                }
                choice = choiceOut;
                switch (choiceOut)
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
                }
            } while (choice != 0);


        }




        /// <summary>
        /// Adding Icecream Food details
        /// </summary>
        public void AddIcecream()
        {
            int choiceOut1, choiceOut2;
            try
            {
                FoodItem fi = new FoodItem();
                //  Auto incerementd serial Number initilises here as Food Id
                fi.FoodId = ++FoodItem.IcreamIdCount;

                fi.FoodType = "Icecream";

                Console.Write("Enter Icecream Id: " + fi.FoodId + " Name:");
                fi.FoodName = Console.ReadLine();
            a:
                Console.Write("Enter Icecream Id: " + fi.FoodId + " Price:");
                bool choice = int.TryParse(Console.ReadLine(), out choiceOut1);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                fi.Price = choiceOut1;

            b:

                Console.Write("Enter Icecream Id: " + fi.FoodId + " Quantity:");
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
                --FoodItem.IcreamIdCount;
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Removing the Food Item Based on Food Id
        /// </summary>

        public void RemoveIcecream()
        {
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> iceCream = listFoodItems.FindAll(item => item.FoodId >= 101 && item.FoodId <= 200);
                if (iceCream.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                iceCream.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in iceCream)
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
                int choiceout;
            a:
                Console.WriteLine("Enter Existing Icecream Id to remove OR 0 to Exit :");
                bool choice = int.TryParse(Console.ReadLine(), out choiceout);
                if (!choice)
                {
                    Console.WriteLine("\n****** Enter Digits only ******\n");
                    goto a;
                }
                if (choiceout == 0)
                    return;
                if (choiceout >= 101 && choiceout <= 200)
                {

                    fi.FoodId = choiceout;
                    fi.FoodType = "Icecream";
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

        public void UdateIcecream()
        {
            int choiceout1, choiceout2;
            try
            {
                AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
                List<FoodItem> listFoodItems = new List<FoodItem>();
                listFoodItems = afi.GetFoodItemBusinessLayer();
                List<FoodItem> iceCream = listFoodItems.FindAll(item => item.FoodId >= 101 && item.FoodId <= 200);
                if (iceCream.Count == 0)
                {
                    Console.WriteLine("\n****** No CoolDrinks avalilable ******\n");
                    return;
                }
                ItemComparer ic = new ItemComparer();
                iceCream.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in iceCream)
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
                Console.Write("Enter Existing Icecream Id to update OR 0 to Exit:");
                bool choice1 = int.TryParse(Console.ReadLine(), out choiceout1);
                if (!choice1)
                {
                    Console.WriteLine("\n****** Enter Digits Only ******\n");
                    goto a;
                }
                if (choiceout1 == 0)
                    return;
                if (choiceout1 >= 101 && choiceout1 <= 200)
                {
                    fi.FoodId = choiceout1;
                }
                else
                {
                    Console.WriteLine("\n****** Invalid Id ******\n");
                    goto a;
                }
            b:
                Console.Write("Enter Icecream Quantity:");
                bool choice2 = int.TryParse(Console.ReadLine(), out choiceout2);
                if (!choice2)
                {
                    Console.WriteLine("\n******Enter Digits Only *******\n");
                    goto b;
                }
                fi.Quantity = choiceout2;
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
