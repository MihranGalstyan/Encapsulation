using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation
{
    class Department2
    {
        private string departName;
        public string DepartName
        {
            get
            {
                return departName;
            }
            set
            {
                departName = value;
            }
        }
    }
}
