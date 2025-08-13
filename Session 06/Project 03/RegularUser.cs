using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal class RegularUser : User
    {
        #region Methods
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        } 

        #endregion
    }
}
