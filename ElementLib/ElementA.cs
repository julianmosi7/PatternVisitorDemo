using System;

namespace ElementLib
{
    public class ElementA : Element
    {

        public string OperationA()
        {
            Console.WriteLine("   ElementA::OperationA");
            return $"A_{Name}";
        }

        public override void Accept(Visitor visitor) => visitor.Visit(this);


        //public override int OperationX() => Name.Length / 2;
        //public override string OperationY() => $"__{OperationA()}__";
    }
}
