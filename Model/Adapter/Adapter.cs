using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterPattern.Adapter
{
    public class PaymentAdapter : PaymentManager, ITarget
    {
        public override string GetAllPayments()
        {
            string returnXml = base.GetAllPayments();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(returnXml);
            return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
        }
    }
}