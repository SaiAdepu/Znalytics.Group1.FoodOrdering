﻿using System;
/// <summary>
/// Represents FoodStoreDetails
/// </summary>
public class FoodStoreDetails
{   //private fields
    private int _storeID;
    private string _storeName;
    private string _location;
    private string _phone;
    private int _rating;
    //automatic or auto implemented property
    public string Email { set; get; }
    public string City { get; set; } = "warangal";
    /// <summary>
    /// Constructor that initializes details of FoodStoreDetails
    /// </summary>
    /// <param name="storeID">Represents id of the store</param>
    /// <param name="storeName">Represents name of the store</param>
    /// <param name="location">Represents location of the store</param>
    /// <param name="phone">Represents phone number of the store</param>
    /// <param name="email">Represents email of the store</param>
    /// <param name="rating">Represents id of the store</param>

    public FoodStoreDetails(int storeID, string storeName, string location, string phone, string email, int rating)
    {
        //_storeID=storeid;
        //_storeName = storename;
        //_location=location;
        //_phone = phone;
        //_email=email;
        //_rating=rating;
    }
    /// <summary>
    /// Parameterless constructor
    /// </summary>
    public FoodStoreDetails()
    {
        //not initializing
    }
    /// <summary>
    /// Static constructor
    /// </summary>
    static FoodStoreDetails()
    {

    }
    ///<sumary>
    /// Represents id of the store
    /// </sumary>
    public int storeID
    {
        set
        {
            //id should contain  5 digits only
            bool b = false;
            if (storeID > int.MaxValue)
            {
                b = true;
            }
            if (b == false)
            {
                _storeID = value;
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
    /// location of foodstore
    /// </summary>

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
        }
        get
        {
            return _rating;
        }
    }
}





























