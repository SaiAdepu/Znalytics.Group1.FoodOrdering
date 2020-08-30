using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Znalytics.Grp1.FoodOrdering.DataAccessLayer;
using Znalytics.Group1.FoodOrdering.Entities;

namespace Znalytics.Grp1.FoodOrdering.BusinessLayer
{
    public class CustomerBusinessLayer : ICustomerBusinessLayer
    {
        private ICustomerDataAcces _customerDataAccess = null;
        public CustomerBusinessLayer()
        {
            _customerDataAccess = new customersDataAccess();
        }

        //Add customer
        public void AddCustomer(Customer customer)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _customerDataAccess.Add(customer);
            }
            else
            {
                throw new Exception("Customer Name can't be null or empty");
            }
        }



        //GetAll Customers
        public List<Customer> GetCustomers()
        {
            return _customerDataAccess.GetCustomers();
        }
        //Update CustomerName
        public void UpdateCustomerName(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                _customerDataAccess.UpdateCustomerName(customer);
            }
        }
        public void UpdateCustomerEmail(Customer customer)
        {
            if (customer.CustomerEmail != null)
            {
                _customerDataAccess.UpdateCustomerEmail(customer);
            }
        }
        public void UpdateCustomerPhoneNumber(Customer customer)
        {
            if (customer.CustomerPhoneNumber != null)
            {
                _customerDataAccess.UpdateCustomerPhoneNumber(customer);
            }
        }
        public void UpdateCustomerAddress(Customer customer)
        {
            if (customer.CustomerAddress != null)
            {
                _customerDataAccess.UpdateCustomerAddress(customer);
            }
        }
        public void UpdateCustomerPassword(Customer customer)
        {
            if (customer.CustomerPasssword != null)
            {
                _customerDataAccess.UpdateCustomerPassword(customer);
            }
        }
    }
}
