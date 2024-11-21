using System;

namespace GENERIC
{
    public class choices
    {
        public int choose;
        crud cd = new crud();
        crud2 cd2 = new crud2();
        public void testing()
        {
            Program.test();
            Console.Write("Choose to Test:");
            choose = int.Parse(Console.ReadLine());

            switch (choose) 
            {
                case 1:
                    Console.WriteLine("\n=STUDENT REPOSITORY MANAGEMENT=");
                    cd.Introduce();
                    break;
                case 2:
                    Console.WriteLine("\n=PRODUCT REPOSITORY MANAGEMENT=");
                    cd2.SecondIntroduce();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        
    }
}
