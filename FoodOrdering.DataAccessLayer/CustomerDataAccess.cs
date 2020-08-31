using System;
using System.Collections.Generic;
using FoodOrdering.Entities;

namespace FoodOrdering.DataAccessLayer
{
    public class CustomerDataAccess:ICustomerDataAccess 
    {
        //private fields
        //stores the list of customers
        private static List<Customer> _customers;
       /* {
            set;
            get;
        }*/

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

        //Update customer
        public void UpdateCustomerName(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }
        public void UpdateCustomerEmail(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerEmail = customer.CustomerEmail;
            }
        }
        public void UpdateCustomerPhoneNumber(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerPhoneNumber = customer.CustomerPhoneNumber;
            }
        }
        public void UpdateCustomerAddress(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerAddress = customer.CustomerAddress;
            }
        }
        public void UpdateCustomerPassword(Customer customer)
        {
            //Get matching customer based on CustomerID
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (cust != null)
            {
                cust.CustomerPassword = customer.CustomerPassword;
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            _customers.RemoveAll(temp =>temp.CustomerName == customer.CustomerName&&temp.CustomerId==customer.CustomerId);
            
        }
    }
}