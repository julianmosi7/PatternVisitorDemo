using System;

namespace ElementLibWithoutVisitor
{
  public class ElementA : Element
  {
    public string OperationA()
    {
      Console.WriteLine("   ElementA::OperationA");
      return $"A_{Name}";
    }

    public override int OperationX() => Name.Length / 2;
    public override string OperationY() => $"__{OperationA()}__";
  }
}
