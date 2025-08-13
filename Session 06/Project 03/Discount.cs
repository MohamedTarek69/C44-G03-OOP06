using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal abstract class Discount
    {
        #region Proprties
        public string? Name { get; set; }

        #endregion

        #region Methods
        public abstract decimal CalculateDiscount(decimal price, int quantity); 

        #endregion

    }
}
