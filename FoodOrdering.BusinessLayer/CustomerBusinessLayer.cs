//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;
//using FoodOrdering.DataAccessLayer;
//using FoodOrdering.Entities;

//namespace FoodOrdering.BusinessLayer
//{
//    /// <summary>
//    /// class that represents customerbusiness layer
//    /// </summary>
//    public class CustomerBusinessLayer:ICustomerBusinessLayer
//    {
//        private ICustomerDataAccess _customerDataAccess=null;
//        public CustomerBusinessLayer()
//        {
//           CustomerDataAccess _customerDataAccess = new CustomerDataAccess();
//        }

//        //method to Add customer
//        public void AddCustomer(Customer customer)
//        {
            
//            if(customer.CustomerName!=null)
//            {
//                _customerDataAccess.AddCustomer(customer);
//            }
//            else
//            {
//                throw new Exception("Customer Name can't be null or empty");
//            }
//        }
       
        

//        //method to GetAll Customers
//        public List<Customer> GetCustomers()
//        {
//            return _customerDataAccess.GetCustomers();
//        }
//        //method to Update CustomerName
//        public void UpdateCustomerName(Customer customer)
//        {
//            if (customer.CustomerName != null)
//            {
//                _customerDataAccess.UpdateCustomerName(customer);
//            }
//        }
//        //method to update customer email
//        public void UpdateCustomerEmail(Customer customer)
//        {
//            if (customer.CustomerEmail != null)
//            {
//                _customerDataAccess.UpdateCustomerEmail(customer);
//            }
//        }
//        //method to update customer phone number
//        public void UpdateCustomerPhoneNumber(Customer customer)
//        {
//            if (customer.CustomerPhoneNumber != null)
//            {
//                _customerDataAccess.UpdateCustomerPhoneNumber(customer);
//            }
//        }
//        //method to update customer Address
//        public void UpdateCustomerAddress(Customer customer)
//        {
//            if (customer.CustomerAddress != null)
//            {
//                _customerDataAccess.UpdateCustomerAddress(customer);
//            }
//        }
//        //method to update customer password
//        public void UpdateCustomerPassword(Customer customer)
//        {
//            if (customer.CustomerPassword != null)
//            {
//                _customerDataAccess.UpdateCustomerPassword(customer);
//            }
//        }
//        //method to delete existing customer based on name and id
//        public void DeleteCustomer(Customer customer)
//        {
//            if((customer.CustomerName!=null)&&(customer.CustomerId!=null))
//            {
//                _customerDataAccess.DeleteCustomer(customer);
//            }
//        }
//        void ICustomerBusinessLayer.ViewCustomer(Customer customer)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
