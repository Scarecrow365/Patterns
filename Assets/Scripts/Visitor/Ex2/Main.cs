using UnityEngine;

namespace Visitor.Ex2
{
    public class Main: MonoBehaviour
    {
        private void Start()
        {
            var e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Cleaner());
            
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());
        }
    }
}