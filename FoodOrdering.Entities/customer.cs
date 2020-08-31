
using System;
using System.Text.RegularExpressions;

namespace FoodOrdering.Entities
{
    public class Customer
    {
        //private fields
        private string _customerName;
        private string _customerId;
        private string _customerEmail;
        private string _customerPhoneNumber;
        private string _customerAddress;
      //  private string _customerPassword;
        Customer customer = new Customer();
        public Customer() { }

        public Customer(string customerName, string customerID, string customerEmail, string customerPhoneNumber, string customerAddress, string customerPassword)
        {

            this.CustomerName = CustomerName;
            this.CustomerId = CustomerId;
            this.CustomerEmail = CustomerEmail;
            this.CustomerPhoneNumber = CustomerPhoneNumber;
            this.CustomerAddress = CustomerAddress;
            this.CustomerPassword = CustomerPassword;
        }

        //properties and validations
        public string CustomerName
        {
            set
            {
                //validating customername
                Regex r = new Regex(@"^[a-zA-Z\s]+$");
                if (r.IsMatch(value))
                {
                    _customerName = value;
                }
                else
                {
                    throw new Exception("customername must contain alphabets and space");
                }
            }
            get
            {
                return _customerName;
            }
        }
        public string CustomerId
        {
            //validating customerid
            set
            {
                if (value.Length > 0 && value.Length < 10)
                {
                    _customerId = value;
                }
                else
                {
                    throw new Exception("customerid must be less than 10 characters");
                }
            }
            get
            {
                return _customerId;
            }
        }
        public string CustomerEmail
        {
            //validating customerEmail
            set
            {
                Regex s = new Regex(@"^([a - zA - Z0 - 9_\-\.] +)@((\[[0 - 9]{ 1,3}\.[0 - 9]{ 1,3}\.[0 - 9]{ 1,3}\.)| (([a - zA - Z0 - 9\-] +\.)+))([a - zA - Z]{ 2,4}|[0 - 9]{ 1,3})(\]?)$");
                if(s.IsMatch(value)==true)
                {
                    _customerEmail = value;
                }
                else
                {
                    throw new Exception("email should not contain spaces and @ symbol is must");
                }
            }
            get
            {
                return _customerEmail;
            }
        }
        public string CustomerPhoneNumber
        {
            //validating customerphonenumber
            set
            {
                Regex t = new Regex(@"^((\+)?(\d{2}[-]))?(\d{10}){1}?$");
                if(t.IsMatch(value))
                {
                    _customerPhoneNumber = value;
                }
                else
                {
                    throw new Exception("phonenumber must be 10 digits");
                }
            }
            get
            {
                return _customerPhoneNumber;
            }

        }
        public string CustomerAddress
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _customerAddress = value;
                }
            }
            get
            {
                return _customerAddress;
            }
        }
        public string CustomerPassword
        {
            //validating customerpassword
            set
            {
                Regex u = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$");
                if (u.IsMatch(value))
                {
                    _customerName = value;
                }
                else
                {
                    throw new Exception("password length must be between 4 and 8. must include at least one upper case letter, one lower case letter, and one numeric digit.");
                }
            }
            get
            {
                return _customerName;
            }
        }
    }
    
}

