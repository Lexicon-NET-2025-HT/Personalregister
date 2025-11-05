

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll(); 
            //Employee emp = new Employee("Kalle",25000);

            payroll.AddEmployee("Nisse", 30000);

            
        }
    }
}
