using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Znalytics.Group1.FoodOrdering.Entities
{
    /// <summary>
    /// Represents FoodStoreDetails
    /// </summary>
    public class FoodStore

    {
        //private fields
        private string _storeID;
        private string _storeName;
        private string _location;
        private string _phone;
        private string _email;
        private int _rating;

        public FoodStore(string storeID, string storeName, string location, string phone, string email, int rating)


        /// Constructor that initializes details of FoodStore
        /// <param name="storeID">Represents id of the store</param>
        /// <param name="storeName">Represents name of the store</param>
        /// <param name="location">Represents location of the store</param>
        /// <param name="phone">Represents phone number of the store</param>
        /// <param name="email">Represents email of the store</param>
        /// <param name="rating">Represents id of the store</param>
        {
            this.StoreID = storeID;
            this.StoreName = storeName;
            this.Location = location;
            this.Phone = phone;
            this.Email = email;
            this.Rating = rating;

        }

        ///<sumary>
        /// StoreID Represents the ID of the FoodStore
        /// </sumary>
        public string StoreID
        {
            set
            {
                //id of the store should be 5 digits 
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

        ///<sumary>
        ///Location Represents Location of the foodstore
        ///</sumary>
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
               // Phone validation factors:
               // 1.No spaces allowed
             // 2.special characters like : ,! # $ % ^ & are not allowed in phone
             // searching for space
          bool spaceFound = phone.Contains(" ");
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
 public string email
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
       bool spaceFound = email.Contains(" ");
       // searching for @
       bool AtFound = email.Contains("@")
       if (!spaceFound && AtFound && (email.EndsWith(".com"))
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
 
    /// <summary>
    /// Rating represents the rating of the FoodStore
    /// </summary>
    public int Rating
    {
        set
        {
        //rating of the foodstore should be between 0 to 5 only
        if (value>=0 && value<=5)
        {
            _rating = value;
        }
        else
        { 
            throw new Exception("rating must be between 0 and 5");
        }
        }
        get
        {
            return _rating;
        }
    }
        
        
































