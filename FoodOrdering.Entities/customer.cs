using System;
using System.Text.RegularExpressions; //Done by spandana///

namespace FoodOrdering.Entities
{
    /// <summary>
    /// class that represents customer details
    /// </summary>
    public class Customer
    {
        //private fields of customer
        private string _customerName;
        private string _customerId;
        private string _customerEmail;
        private string _customerPhoneNumber;
        private string _customerAddress;
        //  private string _customerPassword;
        Customer customer = new Customer();
        public Customer() { }
        //creating and initializing the constructor
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
                Regex r = new Regex(@"^[a-zA-Z\s]+$");//name must contain only alphabets
                                                      //name should not contain digits or special symbols
                                                      //name can have spaces
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
                if (value.Length > 0 && value.Length <= 10)//id must have atleast one character
                                                           //id can have maximum 10 characters
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
                //email should not contain spaces
                //@ symbol is must in email
                //only one @ symbol is accepted
                if (s.IsMatch(value) == true)
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
                Regex t = new Regex(@"^((\+)?(\d{2}[-]))?(\d{10}){1}?$");//phone number must have 10 digits only
                                                                         //phone number cannot have alphabets and special symbols
                if (t.IsMatch(value))
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
            //validating customer address
            set
            {
                if (!string.IsNullOrEmpty(value))//Address must be present
                                                 //Address cannot be null or empty
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
                Regex u = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$");//password length must be between 4 and 8
                                                                               //must include atleast one uppercase letter
                                                                               //must include atleast one lowercase letter
                                                                               //must include atleast one numeric digit
                if (u.IsMatch(value))
                {
                    _customerPassword = value;
                }
                else
                {
                    throw new Exception("password length must be between 4 and 8. must include at least one upper case letter, one lower case letter, and one numeric digit.");
                }
            }
            get
            {
                return _customerPassword;
            }
        }
    }

}

