
namespace ElementLib
{
    public interface Visitor
    {
        void Visit(ElementA elementA);
        void Visit(ElementB elementB);
    }
}
