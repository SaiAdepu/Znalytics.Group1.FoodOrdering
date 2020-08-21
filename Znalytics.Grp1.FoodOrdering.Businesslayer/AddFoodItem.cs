using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znaltyics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;


namespace Znalytics.Grp1.FoodOrdering.Businesslayer
{
    public class AddFoodItem
    {
        public void AddFood(FoodItem fi)
        {
            StoreFoodItems sfi = new StoreFoodItems();

            if (fi.FoodId <= 50 && fi.FoodId >= 1)
            {
                if (fi.FoodName.Length <= 30)
                {
                    if (fi.Price >0)
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
                    throw new System.Exception("Invalid Food Name");
                }
            }
            else
            {
                throw new System.Exception("Invalid Id");
            }

        }
        public void RemoveFoodItem(FoodItem fi)
        {
            StoreFoodItems sfi = new StoreFoodItems();

            if (fi.FoodId != 0)
            {
                sfi.RemoveFoodItem(fi);
            }
        }

        public List<FoodItem> GetFoodItemBusinessLayer()
        {
            StoreFoodItems sfi = new StoreFoodItems();

            return sfi.GetFoodItems();
        }
    }
}
