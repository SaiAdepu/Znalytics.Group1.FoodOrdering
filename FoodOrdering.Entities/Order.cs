
using System;
namespace FoodOrdering.Entities
{
    /// <summary>
    /// Represents Orders;
    /// </summary>
    public class Order
    {
        private int _orderid;
        private string _orderDate;
        private int _storeid;
        private int _foodid;
        private int _quantity;
        private int _customerId;

        /// <summary>
        /// Represents Orderid;
        /// </summary>
        public int Orderid
        {
            set
            {
                if (value != 0)
                {
                    _orderid = value;
                }
                else
                {
                    throw new Exception("entered valid id");
                }
            }
            get
            {
                return _orderid;
            }
        }

        /// <summary>
        /// Represents OrderDate;
        /// </summary>
        public string OrderDate
        {
            set
            {
                if (value.Length <= 7)
                {
                    _orderDate = value;
                }
                else
                {
                    System.Console.WriteLine("entered valid data");
                }
            }

            get
            {
                return _orderDate;

            }
        }

        /// <summary>
        /// represents Storeid;
        /// </summary>
        public int Storeid
        {
            set
            {
                if (value != 10)
                {
                    _storeid = value;
                }
                else
                {
                    throw new Exception("enter valid id");
                }
            }
            get
            {
                return _storeid;
            }
        }

        /// <summary>
        /// represents quantity;
        /// </summary>
        public int Quantity
        {
            set
            {
                if (value >=1 && value <= 10)
                {
                    _quantity = value;
                }
                else
                {
                    throw new Exception("Quantity must be in between 1 and 10 only");
                }
            }
            get
            {
                return _quantity;
            }
        }
        /// <summary>
        /// represents Customerid;
        /// </summary>
        public int Customerid
        {
            set
            {
                if (value != 10)
                {
                    _customerId = value;
                }
                else
                {
                    throw new Exception("entered valid id");
                }
            }
            get
            {
                return _customerId;
            }

        }

        /// <summary>
        /// Represents Foodid;
        /// </summary>
        public int Foodid
        {
            set
            {
                if (value >= 10)
                {
                    _foodid = value;
                }
                else
                {
                    throw new Exception("Incorrect Food Id");
                }
            }
            get
            {
                return _foodid;
            }
        }
    }
}

