using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book {
    internal class Magazine : Book{
        private string _ISSN;
        private int _issue;

        public Magazine() { Category = "MAGAZINE"; }
        public string ISSN { get => _ISSN; set => _ISSN = value; }
        public int IssueNumber { get => _issue; set => _issue = value; }
        public override string GetID() {
            return ISSN + "_" + IssueNumber;
        }

        public override string Writeable() {
            string output = "MAGAZINE_";
            output += "TITLE:" + Title + ";";
            output += "ISSN:" + ISSN + ";";
            output += "ISSUE:" + IssueNumber + ";";
            output += "GENRE:" + Genre + ";";
            output += "PUBLISHER:" + Publisher + ";";
            output += "DESCRIPTION:" + Description + ";";
            foreach (var date in Published) { output += "PUBLISHED:" + date.ToString() + ";"; }
            return output;
        }
    }
}
