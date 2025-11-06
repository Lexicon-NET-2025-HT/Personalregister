using PersonalRegister.Abstractions;
using PersonalRegister.Helpers;

namespace Personalregister
{
    internal class Program
    {
        private static Payroll _payroll = new Payroll();
        private static ConsoleUI _ui = new(); 
        static void Main(string[] args)
        {

            SeedData();
            do
            {
                ShowMainMenu();
                string input = _ui.GetInput();

                switch (input)
                {
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
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
               _ui.Print(employee.Print());
            }
        }

        private static void ShowMainMenu()
        {
            _ui.Print($"{MenuHelpers.Add}.Add {Environment.NewLine}{MenuHelpers.Print}.Print {Environment.NewLine}{MenuHelpers.Quit}.Quit");
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
