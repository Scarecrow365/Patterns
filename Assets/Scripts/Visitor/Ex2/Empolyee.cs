namespace Visitor.Ex2
{
    public class Empolyee : Element
    {
        public string Name { get; set; }
        public int VacationDays { get; set; }
        public double Income { get; set; }

        public Empolyee(string name, double income, int vacationDays)
        { 
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}