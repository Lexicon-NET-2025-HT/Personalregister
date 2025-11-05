


namespace Personalregister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll(); 
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll(); 
            //Employee emp = new Employee("Kalle",25000);         

            SeedData();
            Console.ReadKey(); 
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Nisse", 30000);            
            payroll.AddEmployee("Anna", 35000);            
            payroll.AddEmployee("Kalle", 40000);            
            payroll.AddEmployee("Stina", 45000);            
            payroll.AddEmployee("Sven", 50000);            
        }
    }
}
