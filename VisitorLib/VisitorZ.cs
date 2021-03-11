using ElementLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLib
{
    public class VisitorZ : Visitor
    {
        public int Sum { get; private set; } = 0;
        public void Visit(ElementA elementA)
        {
            Sum += 2;
        }

        public void Visit(ElementB elementB)
        {
            Sum++;
        }

    }
}
