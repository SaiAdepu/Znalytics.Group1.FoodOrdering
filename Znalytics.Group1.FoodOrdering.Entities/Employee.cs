using System;
/// <summary>
/// project of Foodordering ...Employeelogin module(PAVAN KUMAR) 
/// </summary>

namespace Znalytics.Group1.FoodOrdering.Entities
{
    /// <summary>
    /// Represents Food Delivery Employeelogin
    /// </summary>
    public class Employee

    {
        /// <summary>
        /// private fields
        /// </summary>
        private int _employeeID;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _password;
        private long _mobileNumber;


        /// <summary>
        /// employeeID details
        /// </summary>
        public int EmployeeID
        {
            set
            {
                if (value != 0)
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
                    throw new Exception("entered invalid data");
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
                    throw new Exception("entered invalid data");
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
                    throw new Exception("entered invalid data");
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
                    throw new Exception("entered invalid data");
                }
            }

            get
            {
                return _password;
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
    }
}