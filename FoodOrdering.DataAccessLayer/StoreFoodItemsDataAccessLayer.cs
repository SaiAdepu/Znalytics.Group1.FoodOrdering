using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    //Stores food Items
    public class StoreFoodItemsDataAccessLayer
    {
        static List<FoodItem> foodItems = new List<FoodItem>();
        //add food item to list
        public void AddFoodItem(FoodItem fi)
        {
            foodItems.Add(fi);
        }
        
        //removes data based on  id of food
        public void RemoveFoodItem(FoodItem fi)
        {
            foodItems.RemoveAll(item => fi.FoodId == item.FoodId);
            
        }
        //returns food list to Bussiness layer
        public List<FoodItem> GetFoodItems()
        {
            return foodItems;
        }
    }
}
