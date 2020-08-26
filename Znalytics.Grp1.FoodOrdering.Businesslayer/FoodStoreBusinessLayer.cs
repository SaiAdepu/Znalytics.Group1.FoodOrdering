using System;
using System.Collections.Generic;
using Znalytics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.BusinessLayer
{
    public class FoodStoreBusinessLayer
    {
        FoodStoreDataAccess _foodstoreDataAccess;

        public FoodStoreBusinessLayer()
        {
            _foodstoreDataAccess = new foodstoresDataAccess();
        }

        //Add
        public void Add(FoodStore foodstore)
        {
            if (foodstore.StoreName != null)
            {
                _foodstores.DataAccess.Add(foodstore);
            }
            else
            {
                throw new Exception("Store Name can't be null");
            }
        }
        }

        //GetAll 
        public List<FoodStore> GetFoodStores()
        {
            return _foodstoreDataAccess.GetFoodStores();
        }

        public void UpdateFoodStore(FoodStore foodstore)
        {
            if (foodstore.StoreName != null)
            {
                _foodstoreDataAccess.UpdateFoodStore(foodstore);
            }
        }
    }
}
