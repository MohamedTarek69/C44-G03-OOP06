using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_03
{
    internal abstract class User
    {
        #region Properties
        public string? Name { get; set; }

        #endregion

        #region Methods
        public abstract Discount GetDiscount(); 


        #endregion
    }
}
