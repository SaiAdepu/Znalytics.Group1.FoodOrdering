using System;
using System.Collections.Generic;
using FoodOrdering.Entities;
using FoodOrdering.DataAccessLayer;


namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Represents the Validations on Food Fields
    /// </summary>
    public class AddFoodItemBusinessLayer : IAddFoodItemBusinessLayer
    {
        /// <summary>
        /// Adds the food Item into the List If  the inputs are correct
        /// </summary>
        /// <param name="fi"></param>
        public void AddFood(FoodItem fi)
        {
            StoreFoodItemsDataAccessLayer sfi;

            sfi = new StoreFoodItemsDataAccessLayer();


            if (validateFoodName(fi))
            {
                if (fi.Price > 0)
                {
                    if (fi.Quantity > 0)
                    {
                        sfi.AddFoodItem(fi);
                    }
                    else
                    {
                        throw new System.Exception("Invalid quantity");
                    }
                }
                else
                {
                    throw new System.Exception("Invalid price");
                }
            }
            else
            {
                throw new System.Exception("Food Name Already present");
            }


        }
        /// <summary>
        /// validates Food name is used nor not
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public bool validateFoodName(FoodItem fi)
        {
            bool result = true;
            List<FoodItem> f = GetFoodItemBusinessLayer();
            foreach (var item in f)
            {
                if (item.FoodName.Equals(fi.FoodName))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// removes food item from list based on Food Id
        /// </summary>
        /// <param name="fi"></param>
        public void RemoveFoodItem(FoodItem fi)
        {
            StoreFoodItemsDataAccessLayer sfi = new StoreFoodItemsDataAccessLayer();

            if (fi.FoodId != 0)
            {
                sfi.RemoveFoodItem(fi);
            }
            else
            {
                throw new Exception("****** Invalid Food Id ******");
            }
        }


        /// <summary>
        /// updates the Food Item based on Id and Quantity
        /// </summary>
        /// <param name="fi"></param>
        public void UpdateFoofItem(FoodItem fi)
        {

            try
            {

                StoreFoodItemsDataAccessLayer sfi = new StoreFoodItemsDataAccessLayer();
                if (fi.FoodId != 0 && fi.Quantity > 0)
                {
                    sfi.UpdateFoofItem(fi);
                }
                else
                {
                    throw new Exception("****** Invalid Food Id and Quantity ******");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "   " + e.InnerException.Message + "    " + e.StackTrace);
            }

        }


        /// <summary>
        /// returns the List of Food Items to Presenation Layer
        /// </summary>
        /// <returns></returns>
        public List<FoodItem> GetFoodItemBusinessLayer()
        {
            try
            {
                StoreFoodItemsDataAccessLayer sfi = new StoreFoodItemsDataAccessLayer();

                return sfi.GetFoodItems();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the Food Item With respect to food Id given
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FoodItem GetFoodItemByFoodId(int id)
        {

            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = GetFoodItemBusinessLayer();

            FoodItem fitem = listFoodItems.Find(item => item.FoodId == id);
            if (fitem == null)
            {
                throw new Exception("****** No such Food Id Exists ******");
            }
            else
            {
                return fitem;
            }
        }





        /// <summary>
        /// Returns the List of Food Items With resepct to price range of Food given
        /// </summary>
        /// <param name="fromPrice"></param>
        /// <param name="toPrice"></param>
        /// <returns></returns>
        private List<FoodItem> GetFoodItemByPriceRange(int fromPrice, int toPrice)
        {
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = GetFoodItemBusinessLayer();
            List<FoodItem> ListFoodItemsByRange = listFoodItems.FindAll(item => (item.Price >= fromPrice) && (item.Price <= toPrice));
            if (ListFoodItemsByRange.Count == 0)
            {
                throw new Exception("****** No such Food Range Exists ******");
            }
            else
            {
                return ListFoodItemsByRange;
            }
        }

        /// <summary>
        /// returns List Food Depending on the respective Food Type
        /// </summary>
        private List<FoodItem> GetFoodItemByType(string foodType)
        {
            List<FoodItem> listFoodItems = new List<FoodItem>();
            listFoodItems = GetFoodItemBusinessLayer();
            List<FoodItem> ListFoodItemsByType = listFoodItems.FindAll(item => item.FoodType.Equals(foodType));
            if (ListFoodItemsByType.Count == 0)
            {
                throw new Exception("No such Food Type Exists");
            }
            else
            {
                return ListFoodItemsByType;
            }
        }

    }
}
