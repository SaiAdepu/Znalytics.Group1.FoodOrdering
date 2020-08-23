using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znaltyics.Group1.FoodOrdering.Entities;

namespace Znaltyics.Grp1.FoodOrdering.DataAccessLayer
{
    public class detailsfoodstore
    {
    




    {
        //private fields
        private static List<StoreID> StoreID = new List<StoreID>();

        //

        static DataAccessLogic()
        {
            StoreID = new List<StoreID>()
            {
                new (){ StoreID = 10101, StoreName = "Dominos" },
                new StoreID(){ StoreID = 10102, StoreName = "Cream Stone" }
            };
        }

        //Add
        public void AddStoreID(StoreID sid)
        {
            StoreID.Add(sid);
        }

        //remove
        public void RemoveStoreID(StoreID sid)
        {
            StoreID.RemoveAll(item => sid.StoreID == item.StoreID);
        }

        //Get all storeid's
        public List<StoreID> GetStoreID()
        {
            return StoreID;
        }
        //collection

        ArrayList StoreName = new ArrayList() { "Concu", "Almond House", "Barbecue" };

        //AddRange
        StoreName.AddRange= new ArrayList() { "The Coffee Cup", "Olive Bistro", "Paradise" };

        //Add
        Console.WriteLine("Enter new StoreName: ");
            StoreName.Add(System.Console.ReadLine());

            //Insert
            StoreName.Insert(4, "Pizza House");

            //InsertRange
            StoreName.InsertRange(4, new ArrayList() { "Exotica", "Barista", "Cafe Bahar" } );

            //Remove
            StoreName.Remove("The Coffee Cup");

               }

}
















