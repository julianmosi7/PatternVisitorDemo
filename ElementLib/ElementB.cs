using System;

namespace ElementLib
{
    public class ElementB : Element
    {
        private readonly Random random = new Random();



        public int OperationB()
        {
            Console.WriteLine("   ElementB::OperationB");
            return random.Next(10);
        }

        public override void Accept(Visitor visitor) => visitor.Visit(this);

        //public override int OperationX() => OperationB() * 3;
        //public override string OperationY() => Name.ToUpper();
    }
}
