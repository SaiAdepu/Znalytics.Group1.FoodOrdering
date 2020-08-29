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
        public void Add(FoodStore foodstore)
       
        //Viewing the Foodstore

        public List<FoodStore> GetFoodStores()
        {
            // return cdal.GetFoodStores();
        }

        //Updating the Foodstore
        public void UpdateFoodStore(FoodStore foodstore)
        
         
           
        }
}
