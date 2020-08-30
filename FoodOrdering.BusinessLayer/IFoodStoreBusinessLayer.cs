using System;
using System.Collections.Generic;
using FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
   public interface IFoodStoreBusinessLayer
    {
    
        //Adding details
        void AddFoodStore(FoodStore foodstore);
        
        //Viewing existing details
        void ViewFoodStore(FoodStore foodstore);
        
        // GetFoodStore By StoreId(string StoreID);
        //Updating FoodStore details
        void UpdateStoreName(FoodStore foodstore);
        void UpdateLocation(FoodStore foodstore);
        void UpdatePhone(FoodStore foodstore);
        void UpdateEmail(FoodStore foodstore);
        void UpdateRating(FoodStore foodstore);
    }
}
