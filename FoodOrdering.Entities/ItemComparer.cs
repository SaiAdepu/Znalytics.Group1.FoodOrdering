using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Entities
{
    public class ItemComparer : IComparer<FoodItem>
    {
        /// <summary>
        /// Compares two Objects X and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(FoodItem x, FoodItem y)
        {
            int compare;
            compare = x.FoodType.CompareTo(y.FoodType);
            if (compare == 0)
            {
                compare = x.Price.CompareTo(y.Price);
            }
            return compare;
        }
    }
}
