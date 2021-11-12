using System;

namespace Encapsulation
{
    class WriteDepartment
    {
        private string departName;
        public string DepartName
        {
            set
            {
                if (departName != null)
                {
                    departName = value;
                    Console.WriteLine("The Department is : ", departName);
                }
                else
                {
                    Console.WriteLine("The Department is empty");
                }
                
            }
        }
    }
}
