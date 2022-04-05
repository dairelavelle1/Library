using System;
using System.IO;
using AdapterPattern.Adapter;

namespace AdapterPattern
{
    class AdapterTestHarness
    {
        static void Main(string[] args)
        {
            ITarget pay = new PaymentAdapter();
            string value = pay.GetAllPayments();
            Console.WriteLine(value);
            string fileName = @"..\..\CardInfo.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {

                writer.WriteLine(value);
            }

        }
    }
}