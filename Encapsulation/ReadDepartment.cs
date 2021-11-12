using System;

namespace Encapsulation
{
    class ReadDepartment
    {
        private string departname;
        public ReadDepartment(string avalue)
        {
            departname = avalue;
        }
        public string Departname
        {
            get
            {
                return departname;
            }
        }
    }
}
