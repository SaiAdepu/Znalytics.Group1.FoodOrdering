using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class StoreFoodItems
    {
        static List<FoodItem> foodItems = new List<FoodItem>();
        public void AddFoodItem(FoodItem fi)
        {
            foodItems.Add(fi);
        }

        public List<FoodItem> GetFoodItems()
        {
            return foodItems;
        }
    }
}
