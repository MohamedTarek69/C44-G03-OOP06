using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal class PercentageDiscount : Discount
    {
        #region Properties
        public decimal Percentage { get; set; }

        #endregion

        #region Constructors
        public PercentageDiscount(decimal percentage)
        {
            Name = $"Type is PercentageDiscount and the Discount equals => {percentage}%";
            Percentage = percentage;
        }
        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
        #endregion
    }
}
