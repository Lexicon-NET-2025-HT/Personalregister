using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister.Abstractions
{
    public class MockUI : IUI
    {
        public string GetInput()
        {
            return "1"; 
        }

        public void Print(string message)
        {
            
        }
    }
}
