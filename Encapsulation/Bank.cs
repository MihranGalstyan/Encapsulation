using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Bank
    {
        //Hiding class data by declaring the variable as private
        private double balance;

        //Creating public setter and getter methods
        public double GetBalance()
        {
            //Add validation logic if needed
            return balance;
        }
        public void SetBalance(double balance)
        {
            // Add validation logic to check whether data is correct or not
            if (balance > 0)
                this.balance = balance;
        }
    }
}
