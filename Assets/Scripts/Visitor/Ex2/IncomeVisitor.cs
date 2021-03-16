namespace Visitor.Ex2
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Empolyee;

            employee.VacationDays += 3;
        }
    }
}