using System;
using System.Text.RegularExpressions;
///
/// <summary>
///               Project of Foodordering ...Employee module(PAVAN KUMAR) 
/// </summary> // Foodordering.EmployeeModule.Entitieslayer

namespace FoodOrdering.Entities
{
    /// <summary>
    /// Represents Food Delivery Employee 
    /// </summary>////Employee Class
    public class Employee
    {
        /// <summary>
        /// Represents private fields
        /// </summary>
        private int _employeeID;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _mobileNumber;





        /// <summary>
        /// Gets or sets the EmployeId  enter only numbers or else its throw exception
        /// </summary>
        /// EmployeId
        public int EmployeeID
        {
            set  //set Accessor
            {
                if (value != 0) ///if statement and else statement
                {
                    _employeeID = value;
                }
                else
                {
                    throw new Exception("Employeeid Consits only number and try again");
                }
            }
            get //Get Accessor
            {
                return _employeeID;
            }
        }
        /// <summary>
        /// Gets or sets the <b>Email</b>(enter emailid its consists of  Chracters , NUmbers
        ///                                 @ symbol is must,NO spaces,.com is must to write
        /// </summary>
        public string Email
        {
            set  //set Accessor
            {
                if (new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(value) == true)
                {

                    _email = value;
                }
                else
                {
                    throw new Exception("enter emailid its consists of Chracters, Numbers, @ symbol is must,NO spaces,");
                }
            }
            get //Get Accessor
            {
                return _email;
            }
        }



        /// <summary>
        ///************** EmployeeName details***********///
        /// </summary>
        ///   Gets or sets the <b>FirstName</b> enter first name its consists only characters
        public string FirstName
        {
            set  //set Accessor
            {
                if (value.Length >= 4 && value.Length <= 20)
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("entern minimum 4 characters please try again");
                }
            }
            get //Get Accessor
            {
                return _firstName;//returing the First name
            }
        }
        /// <summary>
        ///  Gets or sets the <b>LastName</b> enter  Last name its consists only characters
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
                    throw new Exception("entern minimum 4 characters please try again");
                }
            }
            get //Get Accessor
            {
                return _lastName;
            }
        }
        ///    ****password details***** ///
        /// <summary>
        ///  Gets or sets the <b>Password</b> enter password its consists atleast one captal letters characters 
        ///                                    minimum 6 characters to 15 characters
        /// </summary>


        public string Password
        {
            set  //set Accessor
            {
                if (new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$").IsMatch(value) == true)

                {
                    _password = value;
                }
                else
                {
                    throw new Exception("enter Minimum 6 characters and One Capital Letters must ");
                }
            }

            get //Get Accessor
            {
                return _password;
            }
        }
        /// <summary>
        ///  Gets or sets the <b>Mobile Number</b> enter MObilenumber its consists only Numbers
        ///                                   no symbols,no characters
        /// </summary>
        public string MobileNumber
        {
            set  //set Accessor
            {
                if (new Regex(@"^((\+)?(\d{2}[-]))?(\d{10}){1}?$").IsMatch(value) == true)
                {
                    _mobileNumber = value;
                }
                else
                {
                    throw new Exception("enter Minimum 10 numbers no spaces ,no symbols");
                }
            }
            get //Get Accessor
            {
                return _mobileNumber;
            }
        }

    }
}
