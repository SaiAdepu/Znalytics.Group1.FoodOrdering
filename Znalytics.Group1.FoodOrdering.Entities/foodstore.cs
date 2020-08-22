using System;
/// <summary>
/// Represents FoodStoreDetails
/// </summary>
public class FoodStoreDetails
{   //private fields
    private int _storeID;
    private string _storeName;
    private string _location;
    private int _phone;
    private string _email;
    private int _rating;

    /// <summary>
    /// Constructor that initializes details of FoodStoreDetails
    /// </summary>
    /// <param name="storeID">Represents id of the store</param>
    /// <param name="storeName">Represents name of the store</param>
    /// <param name="location">Represents location of the store</param>
    /// <param name="phone">Represents phone number of the store</param>
    /// <param name="email">Represents email of the store</param>
    /// <param name="rating">Represents id of the store</param>

    public FoodStoreDetails(int storeID, string storeName, string location, int phone, string email, int rating)
    { 
        //_storeID=storeID;
        //_storeName = storeName;
        //_location=location;
        //_phone = phone;
        //_email=email;
        //_rating=rating;

        StoreID = storeID;
        StoreName = storeName;
        Location = location;
        Phone = phone;
        Email = email;
        Rating = rating;
    }
    
     ///<sumary>
    /// Represents id of the store
    /// </sumary>
    public int StoreID
    {
        set
        {
            //id should contain  5 digits only
            if (value != 0)
            {
                _storeID = value;
            }
            else
            {
                throw new Exception("invalid id");
            }
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
        }
    }

    /// <summary>
    /// rating
    /// </summary>
    public int Rating
    {
        set
        {
        //rating should be less than or equal to 5 only
        if (value <= 5)
        {
            _rating = value;
        }
        else
        { 
            throw new Exception("invalid rating");
        }
        }
        get
        {
            return _rating;
        }
    }
}






























