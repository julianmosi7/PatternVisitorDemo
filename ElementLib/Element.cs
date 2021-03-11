namespace ElementLib
{
  public abstract class Element
  {
    public string Name { get; set; }
    public abstract void Accept(Visitor visitor);
  }
}
