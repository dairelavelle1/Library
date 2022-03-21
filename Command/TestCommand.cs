using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class TestCommand : ICommand
    {
        private string _payload = string.Empty;

        public TestCommand(string payload)
        {
            this._payload = payload;
        }
        public void Execute()
        {
            Console.WriteLine($"{ this._payload}");
        }
    }
}
