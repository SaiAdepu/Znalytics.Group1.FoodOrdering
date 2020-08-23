
using System;

namespace Znalytics.Customer.Entities
{
    public class Customer
    {
        //private fields
        private string _customerName;
        private string _customerId;
        private string _customerEmail;
        private string _customerPhoneNumber;
        private string _customerAddress;
        private string _customerPassword;

        //properties and validations
        public string CustomerName
        {
            set
            {
                //validating customername
                if (value.Length <= 30)
                {
                    _customerName = value;
                }
                else
                {
                    throw new Exception("customername must be less than 31 characters");
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
                if (value.Length <= 13)
                {
                    _customer = value;
                }
                else
                {
                    throw new Exception("customerid must be less than 14 characters");
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
                bool isSpaceFound = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == ' ')
                    {
                        isSpaceFound = true;
                    }
                }
                if (isSpaceFound == false)
                {
                    _customerEmail = value;
                }
                else
                {
                    throw new Exception("Enter valid email");
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
                if (value.Length == 10)
                {
                    _customerPhoneNumber = value;
                }
                else
                {
                    throw new Exception("Enter valid phone number");
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
                _customerAddress = value;
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
                if (value.Length <= 10)
                {
                    _customerName = value;
                }
                else
                {
                    throw new Exception("password length must be less than 11");
                }
            }
            get
            {
                return _customerName;
            }
        }
    }

    //constructor to initialize customer details
    public Customer(string customerName,string customerID,string customerEmail,string customerPhoneNumber,string customerAddress,string customerPassword)
    {

        this.CustomerName = CustomerName;
        this.CustomerId = CustomerId;
        this.CustomerEmail = CustomerEmail;
        this.CustomerPhoneNumber = CustomerPhoneNumber; 
        this.CustomerAddress= CustomerAddress;
        this.CustomerPassword = CustomerPassword;
    }
}
}
