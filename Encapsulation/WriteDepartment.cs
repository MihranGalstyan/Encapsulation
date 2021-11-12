using System;

namespace Encapsulation
{
    class WriteDepartment
    {
        private string departname;
        public string Departname
        {
            set
            {
                if (departname != null)
                {
                    departname = value;
                    Console.WriteLine("The Department is : ", departname);
                }
                else
                {
                    Console.WriteLine("The Department is empty");
                }
                
            }
        }
    }
}
