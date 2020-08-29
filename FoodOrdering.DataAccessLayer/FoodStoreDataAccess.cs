﻿using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.DataAccessLayer
{
   public class FoodStoreDataAccess:IFoodStoreDataAccess
   { 
     //private fields
     private static List<FoodStore> _foodstore;
     //constructor
     static FoodStoreDataAccess()
   {
      _foodstore = new List<FoodStore>()
   {
     new FoodStore(){ StoreID="10101",StoreName="Barista",Location="Hyderabad",Phone="9999900000",Email="Barista1@gmail.com",Rating="4"}
     new FoodStore(){ StoreID="10102",StoreName="Coffee Cup",Location="Warangal",Phone="9999955555",Email="coffeecup12@gmail.com",Rating="5"}
     new FoodStore(){ StoreID="10103",StoreName="Bombay House",Location="Hyderabad",Phone="9999944444",Email="house123@gmail.com",Rating="3"}
   };
   }
   public void Add(FoodStore foodstore)
    {
      _foodstore.Add(foodstore);
    }
   //Removing  foodstore Details
   public void Remove(FoodStore foodstore)
   {
            _foodstore.Remove(item => FoodStore.StoreID == item.StoreID);
   }
   //Geting all Foodstore Details
   public void ViewFoodStore(FoodStore foodstore)
   {
   List<FoodStore> GetFoodStore()
   {
    return _foodstore;
   }
   }
  //Updation of the  Foodstore
  public void UpdateFoodStore(FoodStore foodstore)
  {
    //Geting the matching foodstore based on StoreID
   foodstore fs = _foodstore.Find(temp => temp.StoreID == foodstore.StoreID);
   if (fs != null)
    {
     fs.StoreName = foodstore.StoreName;
    }
   }
 }
}




