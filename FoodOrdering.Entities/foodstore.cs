//created by Aishwarya
//Entities
//Module-FoodStore
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Entities
{
    /// <summary>
    /// This Class Represents FoodStoreDetails
    /// </summary>
    public class FoodStore
    {
        //private fields
        private string _storeID;
        private string _storeName;
        private string _location;
        private string _phone;
        private string _email;

        public FoodStore()
        {
        }
        public FoodStore(string storeID, string storeName, string location, string phone, string email  )
        // Constructor that initializes details of FoodStore
        // <param name="storeID">Represents id of the store</param>
        // <param name="storeName">Represents name of the store</param>
        // <param name="location">Represents location of the store</param>
        // <param name="phone">Represents phone number of the store</param>
        // <param name="email">Represents email of the store</param>
        {
            _storeID = StoreID;
            _storeName = StoreName;
            _location = Location;
            _phone = Phone;
            _email = Email;

        }
        ///<summary> 
        /// StoreID Represents the ID of the FoodStore
        ///</summary>
        public string StoreID
        {
            set
            {
                //id of the store should contain 5 digits 
                if (value.Length == 5)
                {
                    _storeID = value;
                }
                else
                {
                    throw new Exception("invalid id");
                }
            }
            get
            {
                return _storeID;
            }
        }
        /// <summary>
        /// StoreName Represents the Name of the FoodStore
        /// </summary>
        public string StoreName
        {
            set
            {
                //Name should be less than 20 string characters
                if (value.Length <= 20)
                {
                    _storeName = value;
                }
            }
            get
            {
                return _storeName;
            }
        }
        ///<summary>
        /// Location Represents Location of the foodstore
        ///</summary>
        public string Location
        {
            set
            {
                _location = value;
            }
            get
            {
                return _location;
            }
        }
        /// <summary>
        /// Phone represents the Phone number of the foodstore
        /// </summary>
        public string Phone
        {
            set
            {
                // Phone validation factors
                // 1.No spaces allowed
                // 2.special characters like : ,! # $ % ^ & are not allowed in phone
                // searching for space
                bool spaceFound = Phone.Contains(" ");
                //Phone number should contain 10 digits only
                if (value.Length == 10 && !spaceFound)
                {
                    _phone = value;
                }
                else
                {
                    throw new Exception("Phone number should contain 10 digits only");
                }
            }
            get
            {
                return _phone;
            }
        }
        /// <summary>
        /// Email reprsents email of the Foodstore
        /// </summary>    
        public string Email
        {
            // Email validation factors:
            //1. No spaces allowed
            //2. @ symbol should be present
            //3. @ should be present only once
            //4. Some special characters like : ,! # $ % ^ & not allowed
            //5. Should end with.com.
            set
            {
                //searching for space
                bool spaceFound = Email.Contains(" ");
                // searching for @
                bool AtFound = Email.Contains("@");
                if (!spaceFound && AtFound && (Email.EndsWith(".com")))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Email should contain only one @ symbol; no space and also end with .com");
                }
            }
            get
            {
                return _email;
            }
        }
    }
}

               
                
                
           
                
            
            
            
            
        
    

        
        
































