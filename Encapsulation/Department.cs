using System;

namespace Encapsulation
{
    class Department
    {
        private string departName;

        // Accessor.  
        public string GetDepartName()
        {
            return departName;
        }

        // Mutator.  
        public void SetDepartName(string name)
        {
            departName = name;
        }
    }
}
