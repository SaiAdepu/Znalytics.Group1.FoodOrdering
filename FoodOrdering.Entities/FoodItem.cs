using System;

namespace FoodOrdering.Entities
{
    /// <summary>
    /// Stores the data of One Food Item
    /// </summary>
    public class FoodItem
    {
        public static int CoolDrinkIdCount = 1;
        public static int IcreamIdCount = 101;
        public static int VegIdCount = 201;
        public static int NonVegIdCount = 301;
        private int _foodId;
        private string _foodType;
        private string _foodName;
        private int _price;
        private int _quantity;

        public int FoodId
        {
            set
            {
                if (value >= 1)
                    _foodId = value;
                else
                    throw new Exception("\n****** Invalid Id ******\n");
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
                    throw new Exception("\n****** Invalid Food Type ******\n");
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
                    throw new Exception("\n****** Invalid Food Name ******\n"); 
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
                    throw new Exception("\n****** Invalid price ******\n");
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
                if (value >= 1)
                    _quantity = value;
                else
                    throw new Exception("\n****** Invalid Quantity ******\n");
            }
            get
            {
                return _quantity;
            }
        }
    }
}
