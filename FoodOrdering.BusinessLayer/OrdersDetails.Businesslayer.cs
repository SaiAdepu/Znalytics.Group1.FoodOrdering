using System;
using System.Collections.Generic;
using FoodOrdering.BusinessLayer;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;
using OrdersDataAccessLayers;

namespace FoodOrdering.BusinessLayer
{
    /// <summary>
    /// Represents Business Layer of the Orders Details
    /// </summary>
    //Interface of the BusinessLayer
    public class OrdersBusinessLayer //OrdersBusinessLayer
    {
        OrdersDataAccess ordersDataAccess;
        //constructor for business layer
        public OrdersBusinessLayer()
        {
            OrdersDataAccess ordersDataAccess = new OrdersDataAccess();
        }


        //Adding Orders
        public void AddOrders(Order order)
        {

            // validating the Orderid
            if (order.Orderid != null) 
            {
                ordersDataAccess.AddOrders(order);
            }
            else
            {
                throw new Exception("orderid can't be null or empty");
            }
        }

        public List<FoodItem> GetFoodItems()
        {
            AddFoodItemBusinessLayer afbl = new AddFoodItemBusinessLayer();
            return afbl.GetFoodItemBusinessLayer();
        }

              //GetAll 
        public List<Order> GetOrders()
        {
            return ordersDataAccess.Getorders();

        }
        //Updating Orders
        public void UpdateOrders(Order order)
        {
            try
            {
                if (order != null)
                {
                    ordersDataAccess.UpdateOrder(order);
                }
            }catch(Exception e)
            {
                throw;
            }
        }
        //Updating Orderid
        public void Updateorderid(Order order)
        {
            try
            {
                if (order.Orderid != null)
                {
                    ordersDataAccess.Updateorderid(order);
                }
            }catch(Exception e)
            {
                throw;
            }
        }
        //Updating orderdate
        public void Upadateorderdate(Order order)
        {
            try
            {
                if (order.OrderDate != null)
                {
                    ordersDataAccess.Upadateorderdate(order);
                }
            }catch(Exception e)
            {
                throw;
            }
        }
     
    }

}