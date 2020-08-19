using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group1.FoodOrdering.Entities
{
    public class FoodItem
    {
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
                if (value!="")
                    _foodName = value;
                else
                    throw new Exception("Invalid Food Name");


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
                if (value != 0)
                    _price = value;
                else
                    throw new Exception("Invalid price");


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
                if (value != 0)
                    _quantity = value;
                else
                    throw new Exception("Invalid Quantity");

            }
            get
            {
                return _quantity;
            }
        }
    }
}
