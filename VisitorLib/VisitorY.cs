using ElementLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLib
{
    public class VisitorY : Visitor
    {
        private List<string> names = new List<string>();

        public void Visit(ElementA elementA)
        {
            string s = $"__{elementA.OperationA()}";
            names.Add(s);
        }

        public void Visit(ElementB elementB)
        {
            string s = elementB.Name.ToUpper();
            names.Add(s);
        }

        public string Result => string.Join(";", names);
    }
}
