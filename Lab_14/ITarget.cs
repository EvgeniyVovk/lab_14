using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Lab_14
{
    interface ITarget
    {
        void AddToCsv(string list, string fileName);
    }
}
