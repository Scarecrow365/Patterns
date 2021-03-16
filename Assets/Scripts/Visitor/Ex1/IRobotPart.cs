namespace Visitor.Ex1
{
    public interface IRobotPart
    {
        void Accept(IRobotPartVisitor robotPartVisitor);
    }
}