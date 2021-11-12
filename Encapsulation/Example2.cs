using System;

namespace Encapsulation
{
    public class Example2
    {
        private int x;
        public int GetX()
        {
            return x;
        }
        public void SetX(int x)
        {
            if (x > 0)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine("Please enter a positive value");
            }
        }
    }
}
