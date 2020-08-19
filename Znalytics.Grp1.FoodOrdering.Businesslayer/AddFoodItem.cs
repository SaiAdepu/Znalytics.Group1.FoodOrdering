using Znaltyics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;


namespace Znalytics.Grp1.FoodOrdering.Businesslayer
{
      
   public  class AddFoodItem
    {
        StroeFoodItems sfi = new StroeFoodItems();
        public void AddFood(FoodItem fi)
        {
            if (fi.FoodId <= 50 && fi.FoodId >= 1)
            {
                if (fi.FoodName.Length <= 30)
                {
                    if (fi.Price < 250)
                    {
                        if (fi.Quantity > 250)
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
    }
}
