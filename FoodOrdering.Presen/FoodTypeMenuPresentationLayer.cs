using FoodOrdering.Entities;
using FoodOrdering.BusinessLayer;
using System;
using System.Collections.Generic;
namespace HootelStoreFooditems
{
    /// <summary>
    /// Represnts all the types of Operations and Retriving Data
    /// </summary>
    public class FoodTypeMenuPresentationLayer
    {
        /// <summary>
        /// Displays the Food menu
        /// </summary>
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>********** $ @ WELCOME TO FOOD STORAGE @ $ **********<<<<<<<<<<<<<<<<<");
            int choice;
            try
            {
                do
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("1.Cool Drinks\n2.Ice Creams\n3.Non-Veg\n4.Veg\n5.View Food Items\n6.Get FoodItem By FoodId\n7.Get FoodItem By FoodType\n8.Get FoodItem By Price Range\n0.Exit");
                    Console.Write("Enter choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            CooldrinksMenuPresentationLayer cm = new CooldrinksMenuPresentationLayer();
                            cm.CoolDrinkOperation();
                            break;
                        case 2:
                            IcecreamPresentationLayer ipl = new IcecreamPresentationLayer();
                            ipl.IcecreamOperation();
                            break;
                        case 3:
                            NonVegPresenationLayer npl = new NonVegPresenationLayer();
                            npl.NonVegOperation();
                            break;
                        case 4:
                            VegPresenationlayer vpl = new VegPresenationlayer();
                            vpl.VegOperation();
                            break;
                        case 5: FoodItemDisplay(); break;
                        case 6:
                            GetFoodItemByFoodId();
                            break;
                        case 7:
                            GetFoodItemByType();
                            ;
                            break;
                        case 8:
                            GetFoodItemByPriceRange();
                            break;
                    }

                } while (choice != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }

        }





        /// <summary>
        /// Displays List Food Depending on the respective Food Type
        /// </summary>
        private void GetFoodItemByType()
        {
            AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();
            Console.Write("Enter Food Type: ");
            string foodType = Console.ReadLine();
            List<FoodItem> ListFoodItemsByType = listFoodItems.FindAll(item => item.FoodType.Equals(foodType));
            if (ListFoodItemsByType.Count == 0)
            {
                Console.WriteLine("No such Food Type Exists");
            }
            else
            {
                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in ListFoodItemsByType)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");

            }
        }





        /// <summary>
        /// Displays the List of Food Items With resepct to price range of Food given
        /// </summary>
        private void GetFoodItemByPriceRange()
        {
            AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();
            int fromPrice, toPrice, from, to;
        a:
            Console.Write("Enter Price from: ");
            bool frombool = int.TryParse(Console.ReadLine(), out from);
            if (!frombool)
            {
                Console.WriteLine("******Enter digits Only ******");
                goto a;
            }
            fromPrice = from;
        b:
            Console.Write("Enter Price To: ");
            bool tobool = int.TryParse(Console.ReadLine(), out to);
            if (!tobool)
            {
                Console.WriteLine("******Enter digits Only ******");
                goto b;
            }
            toPrice = to;
            List<FoodItem> ListFoodItemsByRange = listFoodItems.FindAll(item => (item.Price >= fromPrice) && (item.Price <= toPrice));
            if (ListFoodItemsByRange.Count == 0)
            {
                Console.WriteLine("****** No such Food Range Exists ******");
            }
            else
            {
                ItemComparer ic = new ItemComparer();
                ListFoodItemsByRange.Sort(ic);

                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                foreach (FoodItem item in ListFoodItemsByRange)
                {
                    Console.Write(item.FoodId);
                    Console.Write("\t\t" + item.FoodType);
                    Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                    Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                    Console.Write("\t\t" + item.Quantity);
                    Console.Write("\n");
                }
                Console.WriteLine("**************************************************************************************");

            }
        }




        /// <summary>
        /// Display the total Food items in the list
        /// </summary>
        public void FoodItemDisplay()
        {
            AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();

            ItemComparer ic = new ItemComparer();
            listFoodItems.Sort(ic);

            Console.WriteLine("**************************************************************************************");
            Console.Write("FoodId");
            Console.Write("\t\tFoodType");
            Console.Write("\tFoodName");
            Console.Write("\tFoodPrice");
            Console.Write("\tFoodQuantity");
            Console.Write("\n");
            Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
            foreach (FoodItem item in listFoodItems)
            {
                Console.Write(item.FoodId);
                Console.Write("\t\t" + item.FoodType);
                Console.Write((item.FoodType.Length < 8) ? ("\t\t" + item.FoodName) : ("\t" + item.FoodName));
                Console.Write((item.FoodName.Length < 8) ? ("\t\t" + item.Price) : ("\t" + item.Price));
                Console.Write("\t\t" + item.Quantity);
                Console.Write("\n");
            }
            Console.WriteLine("**************************************************************************************");
        }



        /// <summary>
        /// Displays the Food Item With respect to food Id given 
        /// </summary>
        public void GetFoodItemByFoodId()
        {
            AddFoodItemBusinessLayer afi = new AddFoodItemBusinessLayer();
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = afi.GetFoodItemBusinessLayer();
            int fooId, fid;
        abc:
            Console.Write("Enter FoodId: ");
            bool temp = int.TryParse(Console.ReadLine(), out fooId);
            if (!temp)
            {
                Console.Write("****** Enter digit only ****** ");
                goto abc;
            }
            fid = fooId;

            FoodItem fi = listFoodItems.Find(item => item.FoodId == fooId);
            if (fi == null)
            {
                Console.WriteLine("****** No such Food Id Exists ******");
            }
            else
            {
                Console.WriteLine("**************************************************************************************");
                Console.Write("FoodId");
                Console.Write("\t\tFoodType");
                Console.Write("\tFoodName");
                Console.Write("\tFoodPrice");
                Console.Write("\tFoodQuantity");
                Console.Write("\n");
                Console.WriteLine("------\t\t--------\t--------\t---------\t------------\t");
                Console.Write(fi.FoodId);
                Console.Write("\t\t" + fi.FoodType);
                Console.Write((fi.FoodType.Length < 8) ? ("\t\t" + fi.FoodName) : ("\t" + fi.FoodName));
                Console.Write((fi.FoodName.Length < 8) ? ("\t\t" + fi.Price) : ("\t" + fi.Price));
                Console.Write("\t\t" + fi.Quantity);
                Console.Write("\n");
                Console.WriteLine("**************************************************************************************");
            }

        }
    }
}
