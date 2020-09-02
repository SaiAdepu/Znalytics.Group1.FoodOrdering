using System;
using System.Collections.Generic;
using orders.Entities;

namespace Orders.DataAccessLayer
{
    /// <summary>
    /// Represents DataAccessLayer of the orders Details
    /// </summary>
    public class OrdersDataAccess
    {
        //private fields
        private static List<Orders> orders;

        //Adding the orders Details
        List<Orders> orders = new List<Orders>();
        //constructor
        static OrdersDataAccess()
        {
            Orders = new List<orders>()
         }
        new orders()
        {
            Orderid = 1,
         Orderdate = "2020-02-20",
         Userid = 1,
         storeid = 101,
         employeeid = "jones@gmail.com",
         foodid = 2,}

    };
    // Adding orders
    public void Add(Orders orders)
    {
        orders.Add(orders);
    }

    //Geting all orders Details

    List<Orders> Getorders()
    {
        return rders;
    }

    //updating orderid
    public void Updateorderid(Orders orders)
    {
        //Get matching orders based on orderid
        Orders od = orders.Find(temp => temp.orderid == orders.orderid);
        if (od != null)
        {
            od.orderid = orders.orderid;
        }
    }
    //Updating   userid
    public void Updateuserid(Orders orders)
    {
        //Geting the matching userid based on orderid
        Orders od = orders.Find(temp => temp.userid == orders.userid);
        if (od != null)
        {
            od.userid = orders.userid;
        }
    }
    //Updating storeid
    public void Updatestoreid(Orders orders)
    {
        Orders od = orders.Find(temp => temp.storeid == orders.storeid);
        if (od != null)
        {
            od.storeid = orders.storeid;

        }

    }
    //Updating employeeid
    public void Updateemployeeid(Orders orders)
    {
        Orders od = orders.Find(temp => temp.employeeid == orders.employeeid);
        if (od != null)
        {
            od.employeeid = orders.employeeid;
        }

    }


}
}
