 ///</ summary >
/// Represents customer registration
/// </summary>
public class CustomerDetails
{
    //private fields
    private string _customerName;
    private int _customerId;
    private string _customerEmail;
    private string _customerPhoneNumber;
    private string _customerAddress;
    /// </summary>
    /// repesents customer name
    /// </summary>
    public string CustomerName
    {
        //properties
        set
        {
            //name should be less than 30 characters and not null
            if (value != " " && value.Length <= 30)
            {
                _customerName = value;
            }
        }
        get
        {
            return _customerName;
        }
    }
    /// </summary>
    /// represents customerId
    /// </summary>
    public int CustomerId
    {
        set
        {
            // length of the customerid should not exceed range of int
            bool b = false;
            if (CustomerId > int.MaxValue)
            {
                b = true;
            }
            if (b == false)
            {
                _customerId = value;
            }
        }
        get
        {
            return _customerId;
        }
    }
    /// </summary>
    /// represents customerEmail
    /// </summary>
    public string CustomerEmail
    {
        set
        {
            //emailid of customer should not contain spaces
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
        }
        get
        {
            return _customerEmail;
        }
    }
    /// </summary>
    /// represents customer phonenumber
    /// </summary>
    public string CustomerPhoneNumber
    {
        set
        {
            //length of customer phonenumber must be 10
            if (value.Length == 10)
            {
                _customerPhoneNumber = value;
            }
        }
        get
        {
            return _customerPhoneNumber;
        }

    }
    /// </summary>
    /// represents customer addresss
    /// </summary>
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



}



