using System;
using System.Collections.Generic;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            string data = adapter.ReadXml("sample.xml");
            adapter.AddToCsv(data, "output.csv");
        }
    }
}
