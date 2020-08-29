using FoodOrdering.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.DataAccessLayer
{
    public class StoreFoodItemsDataAccessLayer : IEnumerable, IStoreFoodItemsDataAccessLayer
    {
        static List<FoodItem> foodItems = new List<FoodItem>() { new FoodItem() { FoodId = 1, FoodName = "Chiken", FoodType = "Non-Veg", Price = 200, Quantity = 300 },
        new FoodItem() { FoodId = 2, FoodName = "Vennala", FoodType = "Icecream", Price = 100, Quantity = 500 },
        new FoodItem() { FoodId = 3, FoodName = "CocaCola", FoodType = "CoolDrinks", Price = 20, Quantity = 600 },
        new FoodItem() { FoodId = 4, FoodName = "Potato", FoodType = "Veg", Price = 250, Quantity = 200 }};


        //add food item to list
        public void AddFoodItem(FoodItem fi)
        {
            foodItems.Add(fi);
        }

        //removes data based on  id of food
        public void RemoveFoodItem(FoodItem fi)
        {
            if (foodItems.Count != 0)
            {
                foodItems.RemoveAll(item => fi.FoodId == item.FoodId);
            }
            else
            {
                throw new Exception("****** List is empty ******");

            }
        }
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
                    throw new Exception("****** Invalid Id ******");
                }
            }
            else
            {
                throw new Exception("****** List is empty ******");

            }

        }
        //returns food list to Bussiness layer
        public List<FoodItem> GetFoodItems()
        {
            if (foodItems.Count != 0)
            {


                return foodItems;
            }
            else
            {
                throw new Exception("****** List is empty ******");

            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in foodItems)
            {
                yield return item;
            }
        }
    }
}
