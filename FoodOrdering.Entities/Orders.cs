
/// <summary>
/// Represents Orders;
/// </summary>
public class Orders
{
    private int _Orderid;
    private int _OrderDate;
    private int _Userid;
    private int _Storeid;
    private int _Employeeid;
    private int _Foodid;

    /// <summary>
    /// Represents Orderid;
    /// </summary>
    public int Orderid
    {
        set
        {
            if (value >= 001)
            {
                Orderid = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return Orderid;
        }
    }
    /// <summary>
    /// Represents OrderDate;
    /// </summary>
    public int OrderDate
    {
        set
        {
            bool OrderDate = true;
        }

        get
        {
            return OrderDate.Date;
        }
    }

    /// <summary>
    /// represents Userid;
    /// </summary>
    public int Userid
    {
        set
        {
            if (value <= 10) ;
            {
                bool Userid = true;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
            get
            {
                return Userid;
            }
        }
    }
    /// <summary>
    /// represents Storeid;
    /// </summary>
    public string Storeid
    {
        set
        {
            if (value.Length <= 10)
            {
                Storeid = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return Storeid;
        }
    }

    /// <summary>
    /// represents Employeeid;
    /// </summary>
    public int Employeeid
    {
        set
        {
            if (value >= 10)
            {
                Employeeid = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return Employeeid;
        }
    }

    /// <summary>
    /// Represents Foodid;
    /// </summary>
    public int Foodid
    {
        set
        {
            if (value >= 001)
            {
                Orderid = value;
            }
            else
            {
                System.Console.WriteLine("enter valid data");
            }
        }
        get
        {
            return Foodid;
        }
    }