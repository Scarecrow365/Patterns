using System.Collections.Generic;

namespace Visitor.Ex2
{
    public class Employees
    {
        private List<Empolyee> _empolyees = new List<Empolyee>();

        public void Attach(Empolyee empolyee)
        {
            _empolyees.Add(empolyee);
        }

        public void Detach(Empolyee empolyee)
        {
            _empolyees.Remove(empolyee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var empolyee in _empolyees)
            {
                empolyee.Accept(visitor);
            }
        }
    }
}