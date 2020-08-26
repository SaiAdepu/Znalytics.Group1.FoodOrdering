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
{   //private fields
        private string _storeID;
    private string _storeName;
    private string _location;
    private string _phone;
    private string _email;
    private int _rating;

    /// <summary>
    /// Constructor that initializes details of FoodStore
    /// </summary>
    /// <param name="storeID">Represents id of the store</param>
    /// <param name="storeName">Represents name of the store</param>
    /// <param name="location">Represents location of the store</param>
    /// <param name="phone">Represents phone number of the store</param>
    /// <param name="email">Represents email of the store</param>
    /// <param name="rating">Represents id of the store</param>

         
     ///<sumary>
    /// Represents id of the store
    /// </sumary>
    public string StoreID
    {
        set
        {
            //id of the store should be 5 digits 
            if (value.Length== 5)
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
    /// Represents name of the store
    /// </summary>
    public string StoreName
    {
        set
        {
            //Name should be less than 20 stringacters
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
    ///location of the foodstore
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
    /// Phone number of the foodstore
    /// </summary>
    public string Phone
    {
        set
        {
            //Phone number should contain 10 digits only
            if (value.Length == 10)
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
    /// email of foodstore
    /// </summary>
    public string Email
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
                _email = value;
            }
            else
                {
                    throw new Exception("enter valid email");
                }
        }
    }

    /// <summary>
    /// rating
    /// </summary>
    public int Rating
    {
        set
        {
        //rating should be between 0 to 5 only
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
  public FoodStore(string storeID, string storeName, string location, string phone, string email, int rating)
        {
            this.StoreID = storeID;
            this.StoreName = storeName;
            this.Location = location;
            this.Phone = phone;
            this.Email = email;
            this.Rating = rating;
        }
}
}






























