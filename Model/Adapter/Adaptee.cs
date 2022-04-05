using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace AdapterPattern
{
    [Serializable]
    public class Payment
    {
        Payment() { }
        public Payment(string customerName, long creditCardNo, int cardExpMonth, int cardExpYear, int cardCVV)
        {
            this.CustomerName = customerName;
            this.CreditCardNo = creditCardNo;
            this.CardExpMonth = cardExpMonth;
            this.CardExpYear = cardExpYear;
            this.CardCVV = cardCVV;
        }

        public string CustomerName { get; set; }
        public long CreditCardNo { get; set; }
        public int CardExpMonth { get; set; }
        public int CardExpYear { get; set; }
        public int CardCVV { get; set; }
    }

    public class PaymentManager
    {
        public List<Payment> payments;
        public PaymentManager()
        {
            payments = new List<Payment>();
            this.payments.Add(new Payment("Nathan Quirke", 4319748529059287, 10, 24, 683));
            this.payments.Add(new Payment("Sarah Smith", 4319907383726105, 09, 22, 346));
            this.payments.Add(new Payment("John Doe", 4319928503782658, 03, 23, 811));
        }
        public virtual string GetAllPayments()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(payments.GetType());
            var settings = new XmlWriterSettings(); settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, payments, emptyNamepsaces);
                return stream.ToString();
            }
        }
    }
}