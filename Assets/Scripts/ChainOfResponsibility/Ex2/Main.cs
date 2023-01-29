using UnityEngine;

namespace ChainOfResponsibility.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            const int num1 = 12;
            const int num2 = 3;

            IChain calc1 = new AddNumbers();
            IChain calc2 = new SubstractNumbers();
            IChain calc3 = new DivideNumbers();
            IChain calc4 = new MultiplyNumbers();

            calc1.SetNextChain(calc2);
            calc2.SetNextChain(calc3);
            calc3.SetNextChain(calc4);

            Numbers myNumbers = new(num1, num2, CalculationType.Add);
            calc1.Calculate(myNumbers);

            Numbers myOtherNumbers = new(num1, num2, CalculationType.Multiply);
            calc1.Calculate(myOtherNumbers);

            Numbers myLastNumbers = new(num1, num2, CalculationType.Divide);
            calc1.Calculate(myLastNumbers);
        }
    }
}