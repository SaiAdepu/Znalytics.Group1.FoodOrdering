using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;
namespace Znalytics.Grp1.FoodOrdering.DataAccessLayer

{
    /// <summary>
    /// Represents interface for the Food Store Details DataAccessLayer
    /// </summary>
    public interface IFoodStoreDataAccess
    {
        //Adding the Foodstore
         void AddFoodStore(IFoodStoreDataAccess foodstore)
       
        //Viewing the Foodstore

        public List<FoodStore> GetFoodStores()
        {
            // return cdal.GetFoodStores();
        }

        //Updating the Foodstore
         void UpdateStoreID(FoodStore foodstore)
         void UpdateStoreName(FoodStore foodstore)
         void UpdateLocation(FoodStore foodstore)
         void UpdatePhone(FoodStore foodstore)
         void UpdateEmail(FoodStore foodstore)
         void UpdateRating(FoodStore foodstore)
        }
}
