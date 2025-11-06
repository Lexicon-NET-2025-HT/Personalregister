using PersonalRegister.Helpers;

namespace Personalregister
{
    internal class Program
    {
        private static Payroll _payroll = new Payroll();
        static void Main(string[] args)
        {

            SeedData();
            do
            {
                ShowMainMenu();
                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        Environment.Exit(0); 
                        break;
                    default:
                        break;
                }
            }
            while (true);
        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");
            _payroll.AddEmployee(name, salary); 

        }

        private static void PrintEmployees()
        {
            IEnumerable<Employee> employees = _payroll.GetEmployees();

            //employees[0].Name = "Sten-Ove"; 
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Print());
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"1.Add {Environment.NewLine}2.Print {Environment.NewLine}Q.Exit");
        }

        private static void SeedData()
        {
            _payroll.AddEmployee("Örjan", 30000);
            _payroll.AddEmployee("Anna", 35000);
            _payroll.AddEmployee("Kalle", 40000);
            _payroll.AddEmployee("Åsa", 45000);
            _payroll.AddEmployee("Åke", 50000);
        }
    }
}
