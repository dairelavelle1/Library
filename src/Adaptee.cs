using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.

    [Serializable]
    public class Payment
    {
        Payment() { }
        public Payment(int CreditCardNo, string CustomerName, int CardExpMonth, int CardExpYear, int CardCVV, double Amount)
        {
            this.CreditCardNo = creditCardNo;
            this.CustomerName = customerName;
            this.CardExpMonth = cardExpMonth;
            this.CardExpYear = cardExpYear;
            this.CardCVV = cardCVV;
            this.Amount = amount;
        }
        [XmlAttribute]
        public int CreditCardNo { get; set; }
        [XmlAttribute]
        public string CustomerName { get; set; }
        public int CardExpMonth { get; set; }
        public int CardExpYear { get; set; }
        public int CardCVV { get; set; }
        public double Amount { get; set; }
    }

    public class PaymentManager
    {
        public List<Payment> payments;
        public PaymentManager()
        {
            payments = new List<Payment>();
            this.payments.Add(new payment(4319748529059287, "James", 10, 24, 683, 400.00));
            this.payments.Add(new payment(4319907383726105, "Nathan", 09, 22, 346, 30.00));
            this.payments.Add(new payment(4319928503782658, "Sarah", 03, 23, 811, 150.00));
        }
        public virtual string GetAllPayments()
        {
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(payments.GetType());
            var settings = new XmlWriterSettings();settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, payments, emptyNamepsaces);
                return stream.ToString();
            }           
        }
    }
