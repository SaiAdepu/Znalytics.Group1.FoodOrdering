using System;
using System.Collections.Generic;
using OrdersBusinessLayer;
//using Orders.Entities;

namespace OrdersBusinessLayer
{
    /// <summary>
    /// Represents Business Layer of the Orders Details
    /// </summary>
    //Interface of the BusinessLayer
    public class OrdersBusinessLayer //OrdersBusinessLayer
    {

        //constructor for business layer
        public OrdersBusinessLayer()
        {
            OrdersBusinessLayer OrdersBusinessLayer = new OrdersBusinessLayer();
        }


        //Adding Orders
        public void AddOrders(OrdersBusinessLayer Orders)
        {
            // validating the Orderid
            if (Orders.orderid != null) ;
            {
                OrdersBusinessLayer.AddOrders((Iorders)orders);
            }
            else
            {
                throw new Exception("orderid can't be null or empty");
            }
        }

        //GetAll 
        public List<orders> GetOrders()
        {
            return orders.GetOrders();

        }
        //Updating Orders
        public void UpdateOrders(orders)
        {
            if (orders.Orders != null)
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Updating Orderid
        public void Updateorderid(orders)
        {
            if (orders.Orderid != null)
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Updating orderdate
        public void upadateorderdate(orders)
        {
            if (orders.orderdate != null)
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Update userid
        public void Upadateuserid(orders)
        {
            if (orders.userid != null) ;
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Update storeid
        public void Upadatestoreid(orders)
        {
            if (orders.storeid != null) ;
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Update employeeid
        public void Upadateemployeeid(orders)
        {
            if (orders.employeeid != null) ;
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }
        //Update foodid
        public void Upadatefoodid(orders)
        {
            if (orders.foodid != null) ;
            {
                OrdersBusinessLayer.UpdateOrders(orders);
            }
        }

    }

}