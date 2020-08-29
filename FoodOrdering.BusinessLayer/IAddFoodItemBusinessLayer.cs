using FoodOrdering.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.BusinessLayer
{
    public interface IAddFoodItemBusinessLayer
    {
        void AddFood(FoodItem fi);
        bool validateFoodName(FoodItem fi);
        void RemoveFoodItem(FoodItem fi);
        void UpdateFoofItem(FoodItem fi);
        List<FoodItem> GetFoodItemBusinessLayer();
    }
}
