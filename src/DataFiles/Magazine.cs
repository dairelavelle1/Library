using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book {
    internal class Magazine : Book{
        private string _ISSN;
        private int _issue;

        public string ISSN { get => _ISSN; set => _ISSN = value; }
        public int IssueNumber { get => _issue; set => _issue = value; }
    }
}
