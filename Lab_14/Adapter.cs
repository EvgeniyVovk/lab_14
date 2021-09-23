using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml;
using System.IO;

namespace Lab_14
{
    class Adapter : Adaptee, ITarget
    {
        public void AddToCsv(string data, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(data);
            }
        }
    }
}
