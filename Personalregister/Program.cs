using PersonalRegister.Abstractions;
using PersonalRegister.Helpers;

namespace Personalregister
{
    internal class Program
    {
        private static Payroll _payroll = new Payroll();
        private static IUI _ui = new ConsoleUI();
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            IUI ui = new ConsoleUI(); 

            Main main = new Main(ui, payroll);
            main.Run();
        }

        
    }
}
