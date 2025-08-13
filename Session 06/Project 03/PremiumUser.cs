using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal class PremiumUser : User
    {
        #region Methods
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }

        #endregion
     
    }
}
