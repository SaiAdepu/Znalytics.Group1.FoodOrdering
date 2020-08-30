using System;
using System.Collections.Generic;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;
using Znalytics.Group1.FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
    public class FoodStoreBusinessLayer
    {
        FoodStoreDataAccess _foodstoreDataAccess;

        public FoodStoreBusinessLayer()
        {
            _foodstoreDataAccess = new FoodStoreDataAccess();
        }

        //Add
        public void Add(FoodStore foodstore)
        {
            if (foodstore.StoreName != null)
            {
                _foodstoreDataAccess.Add(foodstore);
            }
            else
            {
                throw new Exception("Store Name can't be null");
            }
        }

        public List<FoodStore> GetFoodStore()
        {
            throw new NotImplementedException();
        }
    }

    //GetAll 
    public List<FoodStore> GetFoodStore()
    {
        return _foodstoreDataAccess.GetFoodStores();
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
        if(foodstore.Phone!=null)
        {
            _foodstoreDataAccess.updatePhone(foodstore);
        }
    }
    public void UpdateEmail(FoodStore foodstore)
    {
        if(foodstore.Email!=null)
        {
            _foodstoreDataAccess.updateEmail(foodstore);
        }
    }

}


