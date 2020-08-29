// Done by Spandana
using System;
using System.Text.RegularExpressions;

namespace Znalytics.Group1.FoodOrdering.Entities
{
    /// <summary>
    /// Represents CustomerDetails
    /// </summary>
    public class Customer
    {
        //private fields
        private string _customerName;
        private string _customerId;
        private string _customerEmail;
        private string _customerPhoneNumber;
        private string _customerAddress;
        private string _customerPassword;
        Customer customer = new Customer();
        public Customer() { }

        /// Constructor that initializes details of customer
        public Customer(string customerName, string customerID, string customerEmail, string customerPhoneNumber, string customerAddress, string customerPassword)
        {
            /// <param name="customerName">Represents name of the customer</param>
            /// <param name="customerID">Represents Id of the customer</param>
            /// <param name="customerEmail">Represents Email of the customer</param>
            /// <param name="customerPhoneNumber">Represents phone number of the customer</param>
            /// <param name="customerAddress">Represents address of the customer</param>
            /// <param name="customerPassword">Represents password of the customer</param>

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
                //validating customername whether it contains alphabets and spaces only.
                Regex r = new Regex(@"^[a-zA-Z\s]+$");
                if (r.IsMatch(value)==true)
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
            //validating customerid whether it has minimum 1 character and maximum 10 characters.
            set
            {
                if (value.Length > 0 && value.Length <= 10)
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
            //validating customerEmail:
            //1.no spaces
            //2.@ symbol is must and allowed only once
            //3. ends with .com,.in etc..
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
            //validating customerphonenumber whether it has 10 digits or not.
            set
            {
                Regex t = new Regex(@ "^((\+)?(\d{2}[-]))?(\d{10}){1}?$");
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
            //validating customerAddress. It should not be null or empty.
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
            //password length must be between 4 and 8.and must include 
            //atleast one upper case letter.
            //atleast  one lower case letter.
            //atleast one numeric digit.
            set
            {
                Regex u = new Regex(@ "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$");
                if(u.IsMatch(value)==true)
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

