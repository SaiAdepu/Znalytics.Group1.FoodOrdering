using System;
using System.Collections.Generic;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
    public class FoodStoreBusinessLayer : IFoodStoreBusinessLayer
    {
        private IFoodStoreDataAccess _foodstoreDataAccess = null;
        public FoodStoreBusinessLayer()
        {
            FoodStoreDataAccess _foodstoreDataAccess = new FoodStoreDataAccess();
        }

        //Add
        public void AddFoodStore(FoodStore foodstore)
        {
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

        public void UpdateStoreName(FoodStore foodstore)
        {
            if (foodstore.StoreName != null)
            {
                _foodstoreDataAccess.UpdateStoreName(foodstore);
            }
        }

        public void UpdateLocation(FoodStore foodstore)

        {
            if (foodstore.Location != null)
            {
                _foodstoreDataAccess.UpdateLocation(foodstore);

            }
        }
        public void UpdatePhone(FoodStore foodstore)
        {
            if (foodstore.Phone != null)
            {
                _foodstoreDataAccess.UpdatePhone(foodstore);
            }
        }
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




    


