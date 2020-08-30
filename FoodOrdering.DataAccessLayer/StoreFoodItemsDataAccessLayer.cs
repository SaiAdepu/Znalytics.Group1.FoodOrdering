using FoodOrdering.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.DataAccessLayer
{
    /// <summary>
    ///Represents the Storing of Food Items List   
    /// </summary>
    public class StoreFoodItemsDataAccessLayer : IEnumerable, IStoreFoodItemsDataAccessLayer
    {
        static List<FoodItem> foodItems = new List<FoodItem>() { new FoodItem() { FoodId = 301, FoodName = "Chiken", FoodType = "Non-Veg", Price = 200, Quantity = 300 },
        new FoodItem() { FoodId = 101, FoodName = "Vennala", FoodType = "Icecream", Price = 100, Quantity = 500 },
        new FoodItem() { FoodId = 1, FoodName = "CocaCola", FoodType = "CoolDrinks", Price = 20, Quantity = 600 },
        new FoodItem() { FoodId = 201, FoodName = "Potato", FoodType = "Veg", Price = 250, Quantity = 200 }};


        /// <summary>
        /// Adds food item to list
        /// </summary>
        /// <param name="fi"></param>
        public void AddFoodItem(FoodItem fi)
        {
            foodItems.Add(fi);
        }

        /// <summary>
        /// Removes food Item List  based on  Id of food
        /// </summary>
        /// <param name="fi"></param>
        public void RemoveFoodItem(FoodItem fi)
        {
            if (foodItems.Count != 0)
            {
                int remoevNumberOfItemsCount=foodItems.RemoveAll(item => fi.FoodId == item.FoodId);
                if (remoevNumberOfItemsCount <= 0)
                {
                    throw new Exception("\n****** Invalid Food Id ******\n");
                }
            }
            else
            {
                throw new Exception("\n****** List is empty ******\n");

            }
        }

        /// <summary>
        /// Updates the Food Item Quantity based on Food Item Id
        /// </summary>
        /// <param name="fi"></param>
        public void UpdateFoofItem(FoodItem fi)
        {
            int flag = 0;
            if (foodItems.Count != 0)
            {
                foreach (var item in foodItems)
                {
                    if (item.FoodId == fi.FoodId)
                    {
                        item.Quantity = fi.Quantity;
                        flag = 0;
                        break;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    throw new Exception("\n****** Invalid Id ******\n");
                }
            }
            else
            {
                throw new Exception("\n****** List is empty ******\n");

            }

        }
        /// <summary>
        /// Returns food list to Bussiness layer
        /// </summary>
        /// <returns></returns>
        public List<FoodItem> GetFoodItems()
        {
            if (foodItems.Count != 0)
            {
                return foodItems;
            }
            else
            {
                throw new Exception("\n****** List is empty ******\n");

            }
        }
        /// <summary>
        /// Used to return list of Food items One by one
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var item in foodItems)
            {
                yield return item;
            }
        }
    }
}
