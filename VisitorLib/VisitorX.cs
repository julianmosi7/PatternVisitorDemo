using ElementLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLib
{
    public class VisitorX : Visitor
    {
        private int value = 0;

        public void Visit(ElementA elementA)
        {
            int val = elementA.Name.Length / 2;
            val += val;
        }

        public void Visit(ElementB elementB)
        {
            int val = elementB.OperationB() * 3;
            val += val;
        }

        public int Value => value;
    }
}
