using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal class BuyOneGetOneDiscount : Discount
    {
        #region Constructors
        public BuyOneGetOneDiscount()
        {
            Name = "Type is Buy One Get One Discount";
        }

        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
                return (price / 2) * (quantity / 2);
            else
                return 0;
        } 

        #endregion

    }
}
