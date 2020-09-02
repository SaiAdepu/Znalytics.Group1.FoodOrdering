using System;

using System.Collections.Generic;
using FoodOrdering.Entities;

namespace OrdersDataAccessLayers
{
    /// <summary>
    /// Represents DataAccessLayer of the orders Details
    /// </summary>
    public class OrdersDataAccess //: IOrdersDataAccess
    {
        //private fields
        private static List<Order> orders;


        //constructor
        static OrdersDataAccess()
        {
            orders = new List<Order>();
            //{
            // new Order()
            // {
            //Orderid = 1, OrderDate = "2020-02-20", Userid = 1, Storeid = 101, Employeeid = 1, Foodid = 2, }
            //};
        }

        // Adding orders
        public void AddOrders(Order order)
        {
            orders.Add(order);
        }

        //Geting all orders Details

        public List<Order> Getorders()
        {
            return orders;
        }

        public void UpdateOrder(Order order)
        {
            Order o = orders.Find(item => item.Foodid == order.Foodid);
            if (o == null)
            {
                throw new Exception("Order id not available");
            }
            else
            {
                o.Quantity = order.Quantity;
            }
        }


        public void Upadateorderdate(Order order)
        {

            Order o = orders.Find(item => item.Orderid == order.Orderid);
            if (o != null)
            {
                o.OrderDate = order.OrderDate;
            }
            else { throw new Exception("Invalid Id"); }

        }

        //updating orderid
        public void Updateorderid(Order order)
        {
            //Get matching orders based on orderid
            Order od = orders.Find(temp => temp.Orderid == order.Orderid);
            if (od != null)
            {
                od.Orderid = order.Orderid;
            }
        }
        //Updating   userid
        //public void Updateuserid(Order order)
        //{
        //    //Geting the matching userid based on orderid
        //    Order od = orders.Find(temp => temp.Customerid == order.Customerid);
        //    if (od != null)
        //    {
        //        od.userid = order.userid;
        //    }
        //}
        //Updating storeid
        //public void Updatestoreid(Order order)
        //{
        //    Order od = orders.Find(temp => temp.Storeid == order.storeid);
        //    if (od != null)
        //    {
        //        od.storeid = order.storeid;

        //    }

        //}
        //Updating employeeid`                                                   
        //public void Updateemployeeid(Order order)
        //{
        //    Order od = orders.Find(temp => temp.employeeid == order.employeeid);
        //    if (od != null)
        //    {
        //        od.employeeid = order.employeeid;
        //    }

        //}


    }
}
