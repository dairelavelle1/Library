using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;

namespace Library
{
    class BuildMagazineCommand : ICommand
    { 
        private string _payload = string.Empty;

        public BuildMagazineCommand(string payload)
        {
            this._payload = payload;
        }
        public void Execute()
        {
            Director myDirector = new Director();
            MagazineBookBuilder magazineBookBuilder = new MagazineBookBuilder();
            myDirector.generateBook(magazineBookBuilder, this._payload);
        }
    }
}

