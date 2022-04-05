using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Invoker
    {
        private ICommand _adminUser;
        private ICommand _normalUser;
        private ICommand _buildMagazine;
        private ICommand _buildNovel;
        private ICommand _buildTextBook;
        public void SetAdminUser(ICommand command) // Initialize commands.
        {
            this._adminUser = command;
        }

        public void SetNormalUser(ICommand command) // Initialize commands.
        {
            this._normalUser = command;
        }

        public void SetBuildMagazine(ICommand command) // Initialize commands.
        {
            this._buildMagazine = command;
        }

        public void SetBuildNovel(ICommand command) // Initialize commands.
        {
            this._buildNovel = command;
        }

        public void SetBuildTextBook(ICommand command)
        {
            this._buildTextBook = command;
        }

        public void Invoke()
        {
            if (this._normalUser is ICommand)
            {
                this._normalUser.Execute();
            }

            if (this._adminUser is ICommand)
            {
                this._adminUser.Execute();
            }

            if (this._buildMagazine is ICommand)
            {
                this._buildMagazine.Execute();
            }

            if (this._buildNovel is ICommand)
            {
                this._buildNovel.Execute();
            }

            if (this._buildTextBook is ICommand)
            {
                this._buildTextBook.Execute();
            }
        }

    }
}
