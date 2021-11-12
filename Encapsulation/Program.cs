using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department instance1 = new Department();
            instance1.SetDepartname("ELECTRONICS");
            Console.WriteLine("The Department is :" + instance1.GetDepartname());

            Department2 instance2 = new Department2();
            instance2.Departname = "Communication";
            Console.WriteLine("The Department is :{0}", instance2.Departname);

            ReadDepartment instance3 = new ReadDepartment("COMPUTERSCIENCE");
            Console.WriteLine("The Department is: {0}", instance3.Departname);

            WriteDepartment instance4 = new WriteDepartment();
            instance4.Departname = "COMPUTERSCIENCE";

            Bank InecoBank = new Bank();
            InecoBank.setBalance(500);
            Console.WriteLine(InecoBank.getBalance());
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();

            Example1 instance5 = new Example1();
            instance5.x = 50;
            Console.WriteLine(instance5.x);
            instance5.x = -10;
            Console.WriteLine(instance5.x);
            Console.WriteLine("Press any key to exist");
            Console.ReadKey();

            Example2 instance6 = new Example2();
            //We cannot use the variable directly here
            // e.x = 50; //Compile time errr
            // Console.WriteLine(e.x); //Compile time errr
            instance6.setX(10);
            Console.WriteLine(instance6.getX());
            instance6.setX(-50);
            Console.WriteLine(instance6.getX());
            Console.WriteLine("Press any key to exist");
            Console.ReadKey();
        }
    }
}
