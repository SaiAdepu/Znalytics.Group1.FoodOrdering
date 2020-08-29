using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.DataAccessLayer
{
    public interface IStoreFoodItemsDataAccessLayer
    {
        void AddFoodItem(FoodItem fi);
        void RemoveFoodItem(FoodItem fi);
        void UpdateFoofItem(FoodItem fi);
        List<FoodItem> GetFoodItems();
    }
}
