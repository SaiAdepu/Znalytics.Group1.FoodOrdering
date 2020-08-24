using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.DataAccessLayer
{
    public class FoodStoreDataAccess
    {
        //private fields
        private static List<FoodStore> _foodstores;

        //constructor
        static FoodStoreDataAccess()
        {
            _foodstores = new List<FoodStore>()
            {
                new FoodStore(){ StoreID="10101",StoreName="Barista",Location="Hyderabad",Phone="9999900000",Email="Barista1@gmail.com",Rating="4"}
                new FoodStore(){ StoreID="10102",StoreName="Coffee Cup",Location="Warangal",Phone="9999955555",Email="coffeecup12@gmail.com",Rating="5"}
                new FoodStore(){ StoreID="10103",StoreName="Bombay House",Location="Hyderabad",Phone="9999944444",Email="house123@gmail.com",Rating="3"}

            };
        }

        //Add Foodstore
        public void Add(FoodStore foodstore)
        {
            _foodstores.Add(foodstore);
        }

        //Get all Foodstores
        public List<FoodStore> GetFoodStores()
        {
            return _foodstores;
        }

        //Update Foodstore
        public void UpdateFoodStore(FoodStore foodstore)
        {
            //Get matching foodstore based on StoreID
          foodstore fs = _foodstores.Find(temp => temp.StoreID == foodstore.StoreID);
            if (fs != null)
            {
                fs.StoreName = foodstore.StoreName;
            }
        }
    }
}



