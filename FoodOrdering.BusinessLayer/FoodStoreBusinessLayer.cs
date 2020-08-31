using System;
using System.Collections.Generic;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Represents Business Layer of the FoodStore Details
    /// </summary>
    public class FoodStoreBusinessLayer : IFoodStoreBusinessLayer//Interface of the BusinessLayer
    {
        private IFoodStoreDataAccess _foodstoreDataAccess=null;
        public FoodStoreBusinessLayer()//constructor for business layer
        {
            FoodStoreDataAccess _foodstoreDataAccess = new FoodStoreDataAccess(); //object creation of data access layer
        }


        //Adding FoodStore
        public void AddFoodStore(FoodStore foodstore)
        {
            // validating the store name
            if (foodstore.StoreName != null)
            {
                _foodstoreDataAccess.AddFoodStore((IFoodStoreDataAccess)foodstore);
            }
            else
            {
                throw new Exception("Store Name can't be null or empty");
            }
        }

        //GetAll 
        public List<FoodStore> GetFoodStores()
        {
            return _foodstoreDataAccess.GetFoodStore();

        }
        //Updating StoreName
        public void UpdateStoreName(FoodStore foodstore)
        {
            if (foodstore.StoreName != null)
            {
                _foodstoreDataAccess.UpdateStoreName(foodstore);
            }
        }
        //updating Location
        public void UpdateLocation(FoodStore foodstore)

        {
            if (foodstore.Location != null)
            {
                _foodstoreDataAccess.UpdateLocation(foodstore);

            }
        }
        //updating Phone
        public void UpdatePhone(FoodStore foodstore)
        {
            if (foodstore.Phone != null)
            {
                _foodstoreDataAccess.UpdatePhone(foodstore);
            }
        }
        //Updating Email
        public void UpdateEmail(FoodStore foodstore)
        {
            if (foodstore.Email != null)
            {
                _foodstoreDataAccess.UpdateEmail(foodstore);
            }
        }
        void IFoodStoreBusinessLayer.ViewFoodStore(FoodStore foodstore)
        {
            throw new NotImplementedException();
        }
    }
}




    


