using System;
/// <summary>
/// project of Foodordering ...Employeelogin module 
/// </summary>

namespace Znalytics.Group1.FoodOrdering.Entities
{
    /// <summary>
    /// Represents Food Delivery Employeelogin
    /// </summary>
    public class EmployeeDetail
    {
        /// <summary>
        /// private fields
        /// </summary>
        private string _employeeID;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _confirmPassword;
        private long _mobileNumber;
        private string _foodStoreID;

        /// <summary>
        /// employeeID details
        /// </summary>
        public string EmployeeID
        {
            set
            {
                ///IF Input value and Eployeeid present in database matches then the value will be assigned to the employeeid
                ///Else it will throw an exception
                if ("12345id" == value)
                {
                    _employeeID = value;
                }
                else
                {
                    throw new Exception("entered invalid data");
                }
            }
            get
            {
                return _employeeID;
            }
        }
        /// <summary>
        /// Email details
        /// </summary>
        public string Email
        {
            set
            {
                if (value.Length >= 10 && value.Length <= 30)
                {

                    _email = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }
            get
            {
                return _email;
            }
        }

        /// <summary>
        ///************** EmployeeName details***********///
        /// </summary>
        ///                  first name
        public string FirstName
        {
            set
            {
                if (value.Length >= 4 && value.Length <= 20)
                {
                    _firstName = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }
            get
            {
                return _firstName;
            }
        }
        /// <summary>
        /// lastname 
        /// </summary>
        public string LastName
        {
            set
            {
                if (value.Length >= 4 && value.Length <= 20)
                {
                    _lastName = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }
            get
            {
                return _lastName;
            }
        }
        ///    ****password details***** ///
        /// <summary>
        /// Password 
        /// </summary>
        public string Password
        {
            set
            {
                if (value.Length >= 8 && value.Length <= 30)
                {
                    _password = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }

            get
            {
                return _password;
            }
        }
        /// <summary>
        /// Confirm password 
        /// </summary>
        public string ConfirmPassword
        {
            set
            {
                if (value.Length >= 8 && value.Length <= 30)
                {
                    _confirmPassword = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }

            get
            {
                return
                    _confirmPassword;
            }
        }

        /// <summary>
        /// Mobilenumber details
        /// </summary>
        public long MobileNumber
        {
            set
            {
                if (value < 9)
                {
                    _mobileNumber = value;
                }
            }
            get
            {
                return _mobileNumber;
            }
        }
        /// <summary>
        /// FoodStorageid Details
        /// </summary>
        public string FoodStoreID
        {
            set
            {
                if (value.Length <= 20)
                {
                    _foodStoreID = value;
                }
                else
                {
                    System.Console.WriteLine("enter valid data");
                }
            }
            get
            {
                return _foodStoreID;
            }
        }
    }
}
