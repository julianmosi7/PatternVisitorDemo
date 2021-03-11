namespace ElementLibWithoutVisitor
{
  public abstract class Element
  {
    public string Name { get; set; }
    public abstract int OperationX();
    public abstract string OperationY();
  }
}
