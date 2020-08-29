using System;

namespace FoodOrdering.Entities;
{
    /// <summary>
    /// Stores the data of One Food Item
    /// </summary>
    public class FoodItem
    {
        public static int foodIdCount = 4;
        private int _foodId;
        private string _foodType;
        private string _foodName;
        private int _price;
        private int _quantity;

        public int FoodId
        {
            set
            {
                if (value != 0)
                    _foodId = value;
                else
                    throw new Exception("Invalid Id");
            }
            get
            {
                return _foodId;
            }
        }
        public string FoodType
        {
            set
            {
                if (value.Equals(""))
                    throw new Exception("****** Invalid Food Type ******");
                else
                _foodType = value;
            }
            get
            {
                return _foodType;
            }
        }
        public string FoodName
        {
            set
            {
               
                if (value.Equals(""))
                    throw new Exception("****** Invalid Food Name ******"); 
                else
                    _foodName = value;

            }
            get
            {
                return _foodName;
            }
        }
        public int Price
        {
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    throw new Exception("****** Invalid price ******");
            }
            get
            {
                return _price;
            }
        }
        public int Quantity
        {
            set
            {
                if (value >= 0)
                    _quantity = value;
                else
                    throw new Exception("****** Invalid Quantity ******");
            }
            get
            {
                return _quantity;
            }
        }
    }
}
