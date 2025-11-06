



namespace Personalregister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll(); 
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
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        break;
                    default:
                        break;
                }
            }
            while (true);
        }

        private static void PrintEmployees()
        {
            IEnumerable<Employee> employees = payroll.GetEmployees();

            //employees[0].Name = "Sten-Ove"; 
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"1.Add {Environment.NewLine}2.Print {Environment.NewLine}Q.Exit");
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Örjan", 30000);            
            payroll.AddEmployee("Anna", 35000);            
            payroll.AddEmployee("Kalle", 40000);            
            payroll.AddEmployee("Åsa", 45000);            
            payroll.AddEmployee("Åke", 50000);            
        }
    }
}
