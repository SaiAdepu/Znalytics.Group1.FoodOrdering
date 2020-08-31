﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using FoodOrdering.DataAccessLayer;
using FoodOrdering.Entities;

namespace FoodOrdering.BusinessLayer
{
    public class CustomerBusinessLayer:ICustomerBusinessLayer
    {
        private ICustomerDataAccess _customerDataAccess=null;
        public CustomerBusinessLayer()
        {
           CustomerDataAccess _customerDataAccess = new CustomerDataAccess();
        }

        //Add customer
        public void AddCustomer(Customer customer)
        {
            
            if(customer.CustomerName!=null)
            {
                _customerDataAccess.AddCustomer((ICustomerDataAccess)customer);
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
            if (customer.CustomerPassword != null)
            {
                _customerDataAccess.UpdateCustomerPassword(customer);
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            if((customer.CustomerName!=null)&&(customer.CustomerId!=null))
            {
                _customerDataAccess.DeleteCustomer(customer);
            }
        }
        void ICustomerBusinessLayer.ViewCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
