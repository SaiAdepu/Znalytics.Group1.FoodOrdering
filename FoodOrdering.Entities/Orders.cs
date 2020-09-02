
using System;
namespace Znalytics.Grp1.OnlineFoodOrderSystem
{


    /// <summary>
    /// Represents Orders;
    /// </summary>
    public class orders
    {
        public int orderid;
        public string orderDate;
        public int userid;
        public int storeid;
        public int employeeid;
        public int foodid;

        /// <summary>
        /// Represents Orderid;
        /// </summary>
        public int Orderid
        {
            set
            {
                if (value != 0)
                {
                    orderid = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid id");
                }
            }
            get
            {
                return orderid;
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
                    orderDate = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }

            get
            {
                return orderDate;

            }
        }

        /// <summary>
        /// represents Userid;
        /// </summary>
        public int Userid
        {
            set
            {
                if (value != 10)
                {
                    userid = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid id");
                }
            }
            get
            {
                return userid;
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
                    storeid = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid id");
                }
            }
            get
            {
                return storeid;
            }
        }

        /// <summary>
        /// represents Employeeid;
        /// </summary>
        public int Employeeid
        {
            set
            {
                if (value >= 10)
                {
                    employeeid = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }
            get
            {
                return employeeid;
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
                    foodid = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid id");
                }
            }
            get
            {
                return foodid;
            }
        }
    }
}

