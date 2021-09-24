using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace Lab_14
{
    public class Adaptee
    {
        public string ReadXml(string fileName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string delimiter = " , ";
            try
            {
                XDocument.Load(fileName).Descendants("student").ToList().ForEach(elm =>
                    stringBuilder.Append(elm.Element("name").Value +
                    delimiter + elm.Element("gender").Value + "\n"));
                return stringBuilder.ToString();
            } catch (XmlException e)
            {
                throw new XmlException(e.Message);
            }
        }
    }
}
