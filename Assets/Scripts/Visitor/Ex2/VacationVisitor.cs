namespace Visitor.Ex2
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Empolyee;

            employee.Income *= 1.10;
        }
    }
}