using System;
using System.Collections.Generic;
using Znalytics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.BusinessLayer
{
    public class CustomerBusinessLayer  
    {
        CustomerDataAccess _customerDataAccess;

        public CustomerBusinessLayer()
        {
            _customerDataAccess = new customersDataAccess();
        }

        //Add
        public void Add(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                _customerDataAccess.Add(customer);
            }
            else
            {
                throw new Exception("Customer Name can't be null");
            }
        }

        //GetAll Customers
        public List<Customer> GetCustomers()
        {
            return _customerDataAccess.GetCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                _customerDataAccess.UpdateCustomer(customer);
            }
        }
    }
}
