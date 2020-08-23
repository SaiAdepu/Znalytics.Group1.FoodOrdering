using System;
using System.Collections.Generic;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.DataAccessLayer
{
    public class CustomerDataAccess
    {
        //private fields
        private static List<Customer> _customers;

        //constructor
        static CustomerDataAccess()
        {
            _customers = new List<Customer>()
            {
                new Customer(){ CustomerName="scott",CustomerID = "101",CustomerEmail="Scott@gmail.com",CustomerPhoneNumber="7330968633",CustomerAddress="HYd",CustomerPassword="1234" },
                new Customer(){CustomerName="Allen",CustomerID = "102",CustomerEmail="Allen@gmail.com",CustomerPhoneNumber="7330968630",CustomerAddress="WARANGAL",CustomerPassword="12345"  }
            };
        }

        //Add customer
        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        //Get all customers
        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        //Update customer
        public void UpdateCustomer(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerID == customer.CustomerID);
            if (cust != null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }
    }
}