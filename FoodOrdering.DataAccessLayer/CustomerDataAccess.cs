using System;
using System.Collections.Generic;
using FoodOrdering.Entities;

namespace FoodOrdering.DataAccessLayer
{
    /// <summary>
    /// Represents customerdataaccess class
    /// </summary>
    public class CustomerDataAccess:ICustomerDataAccess 
    {
        //private fields
        //stores the list of customers
        private static List<Customer> _customers;

        List<Customer> customer = new List<Customer>();

        //constructor
        static CustomerDataAccess()
        {
            _customers = new List<Customer>()
            {
                new Customer(){ CustomerName="scott",CustomerId = "101",CustomerEmail="Scott@gmail.com",CustomerPhoneNumber="7330968633",CustomerAddress="HYd",CustomerPassword="1234" },
                new Customer(){CustomerName="Allen",CustomerId = "102",CustomerEmail="Allen@gmail.com",CustomerPhoneNumber="7330968630",CustomerAddress="WARANGAL",CustomerPassword="12345"  }
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

        //method to Update customer name
        public void UpdateCustomerName(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }
        //method to update customerEmail
        public void UpdateCustomerEmail(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerEmail = customer.CustomerEmail;
            }
        }
        //method to update customer phonenumber
        public void UpdateCustomerPhoneNumber(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerPhoneNumber = customer.CustomerPhoneNumber;
            }
        }
        //method to update customer Address
        public void UpdateCustomerAddress(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerAddress = customer.CustomerAddress;
            }
        }
        //methid to update customer password
        public void UpdateCustomerPassword(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerPassword = customer.CustomerPassword;
            }
        }
        //method to delete existing customer based on customername and customerId
        public void DeleteCustomer(Customer customer)
        {
            _customers.RemoveAll(temp =>temp.CustomerName == customer.CustomerName&&temp.CustomerId==customer.CustomerId);
            
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}