//created by Aishwarya
//FoodStoreDataAccess
//module-FoodStore

using System;
using System.Collections.Generic;
using FoodOrdering.Entities;

namespace FoodOrdering.DataAccessLayer
{
    /// <summary>
    /// Represents DataAccessLayer of the FoodStore Details
    /// </summary>
        public class FoodStoreDataAccess 
    {
        //private fields
        private static List<FoodStore> _foodstore
        {
            set;
            get;
        }
        //Adding the FoodStore Details
        List<FoodStore> foodstore = new List<FoodStore>();
        //constructor
        static FoodStoreDataAccess()
        {
            _foodstore = new List<FoodStore>()
   {
     new FoodStore(){ StoreID="10101",StoreName="Barista",Location="Hyderabad",Phone="9999900000",Email="Barista1@gmail.com" },
     new FoodStore(){ StoreID="10102",StoreName="Coffee Cup",Location="Warangal",Phone="9999955555",Email="coffeecup12@gmail.com"},
     new FoodStore(){ StoreID="10103",StoreName="Bombay House",Location="Hyderabad",Phone="9999944444",Email="house123@gmail.com"}
   };
        }
        // Adding FoodStore
        public void Add(FoodStore foodstore)
        {
            _foodstore.Add(foodstore);
        }

        //Geting all Foodstore Details

        List<FoodStore> GetFoodStore()
        {
            return _foodstore;
        }
        
        //updating StoreName
        public void UpdateStoreName(FoodStore foodstore)
        {
            //Get matching storename based on storeID
            FoodStore fs = _foodstore.Find(temp => temp.StoreID == foodstore.StoreID);
            if (fs != null)
            {
                fs.StoreName = foodstore.StoreName;
            }
        }
        //Updation of the  Foodstore
        public void UpdateEmail(FoodStore foodstore)
        {
            //Geting the matching email based on StoreID
            FoodStore fs = _foodstore.Find(temp => temp.StoreID == foodstore.StoreID);
            if (fs != null)
            {
                fs.Email = foodstore.Email;
            }
        }
        //Updating The Location FoodStore
        public void UpdateLocation(FoodStore foodstore)
        {
            FoodStore fs = _foodstore.Find(temp => temp.StoreID == foodstore.StoreID);
            if (fs != null)
            {
                fs.Location = foodstore.Location;

            }

        }
        //Updating The Phone FoodStore
        public void UpdatePhone(FoodStore foodstore)
        {
            FoodStore fs = _foodstore.Find(temp => temp.StoreID == foodstore.StoreID);
            if (fs != null)
            {
                fs.Phone = foodstore.Phone;
            }

        }
        
             
            }
        }

    





