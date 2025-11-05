 
namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("R2D2", 67,24500);
            string robotName = robot.GetName();
            Console.WriteLine(robotName);
            robot.SetName("Test");
            robot.Age = -1;
            Console.WriteLine(robot.GetName());
            Console.WriteLine("Test");
            Console.WriteLine(robot.Salary);
            //robot.Salary = 25000;
            robot.SetSalary(25000);


        }
    }
}
