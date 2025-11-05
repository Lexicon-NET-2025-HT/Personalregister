

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Robot r1 = new Robot("R1", 25, 25000);
            Console.WriteLine(Robot.Count);
            Robot r2 = new Robot("R2", 25, 25000);
            Console.WriteLine(Robot.Count);
            Robot r3 = new Robot("R3", 25, 25000);
            Console.WriteLine(Robot.Count);
            Robot r4 = new Robot("R4", 25, 25000);
            Console.WriteLine(Robot.Count);
            Robot r5 = new Robot("R5", 25, 25000);
            Console.WriteLine(Robot.Count);
            //r1.Count;



            Console.ReadKey();
            //Console c = new Console(); 
        }
    }
}
