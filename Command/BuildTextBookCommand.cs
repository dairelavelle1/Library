using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;

namespace Library
{
    class BuildTextBookCommand : ICommand
    {
        private string _payload = string.Empty;

        public BuildTextBookCommand(string payload)
        {
            this._payload = payload;
        }
        public void Execute()
        {
            Director myDirector = new Director();
            TextbookBookBuilder textbookBookBuilder = new TextbookBookBuilder();
            myDirector.generateBook(textbookBookBuilder, this._payload);
        }
    }
}
