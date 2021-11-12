using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department instance1 = new Department();
            instance1.SetDepartName("ELECTRONICS");
            Console.WriteLine("The Department is :" + instance1.GetDepartName());

            Department2 instance2 = new Department2();
            instance2.DepartName = "Communication";
            Console.WriteLine("The Department is :", instance2.DepartName);

            ReadDepartment instance3 = new ReadDepartment("COMPUTERSCIENCE");
            Console.WriteLine("The Department is: ", instance3.Departname);

            WriteDepartment instance4 = new WriteDepartment();
            instance4.DepartName = "COMPUTERSCIENCE";

            Bank inecoBank = new Bank();
            inecoBank.SetBalance(500);
            Console.WriteLine(inecoBank.GetBalance());
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            Example1 instance5 = new Example1();
            instance5.x = 50;
            Console.WriteLine(instance5.x);
            instance5.x = -10;
            Console.WriteLine(instance5.x);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            Example2 instance6 = new Example2();
            //We cannot use the variable directly here
            // e.x = 50; //Compile time errr
            // Console.WriteLine(e.x); //Compile time errr
            instance6.SetX(10);
            Console.WriteLine(instance6.GetX());
            instance6.SetX(-50);
            Console.WriteLine(instance6.GetX());
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
