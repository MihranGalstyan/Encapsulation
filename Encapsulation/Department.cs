using System;

namespace Encapsulation
{
    class Department
    {
        private string departname;

        // Accessor.  
        public string GetDepartname()
        {
            return departname;
        }

        // Mutator.  
        public void SetDepartname(string name)
        {
            departname = name;
        }
    }
}
