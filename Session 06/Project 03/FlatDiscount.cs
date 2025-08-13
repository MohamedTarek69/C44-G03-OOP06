using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal class FlatDiscount : Discount
    {
        #region Properties
        public decimal FlatAmount { get; set; }

        #endregion

        #region Constructors
        public FlatDiscount(decimal amount)
        {
            Name = $"Type is FlatDiscount and the Discount equals => {amount}$";
            FlatAmount = amount;
        }

        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }

        #endregion
    }
}
