using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;

namespace Library
{
    class BuildNovelCommand : ICommand
    {
        private string _payload = string.Empty;

        public BuildNovelCommand(string payload)
        {
            this._payload = payload;
        }
        public void Execute()
        {
            Director myDirector = new Director();
            NovelBookBuilder novelBookBuilder = new NovelBookBuilder();
            myDirector.generateBook(novelBookBuilder, this._payload);
        }
    }
}