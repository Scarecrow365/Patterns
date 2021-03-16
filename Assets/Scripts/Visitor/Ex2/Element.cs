namespace Visitor.Ex2
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}