using System;

namespace ElementLibWithoutVisitor
{
  public class ElementB : Element
  {
    private readonly Random random = new Random();

    public int OperationB()
    {
      Console.WriteLine("   ElementB::OperationB");
      return random.Next(10);
    }

    public override int OperationX() => OperationB() * 3;
    public override string OperationY() => Name.ToUpper();
  }
}
