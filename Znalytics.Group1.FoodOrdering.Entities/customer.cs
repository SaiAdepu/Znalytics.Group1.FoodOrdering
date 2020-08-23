
using System;

namespace Znalytics.Customer.Entities
{
    public class Customer
    {
        private string _customerName;
        private string _customerId;
        private string _customerEmail;
        private string _customerPhoneNumber;
        private string _customerAddress;
        private string _customerPassword

        public string CustomerName
        {
            set
            {
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
