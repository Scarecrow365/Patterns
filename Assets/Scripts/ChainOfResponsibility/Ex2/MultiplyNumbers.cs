using UnityEngine;

namespace ChainOfResponsibility.Ex2
{
    public class MultiplyNumbers : IChain
    {
        protected IChain nextInChain;
		
        public void SetNextChain(IChain nextChain)
        {
            this.nextInChain = nextChain;
        }
		
        public void Calculate(Numbers request)
        {
            if(request.calculationWanted == CalculationType.Multiply)
            {
                Debug.Log("Multiplying: " + request.number1 + " * " + request.number2 + " = " + (request.number1 * request.number2).ToString());
            }
            else if(nextInChain != null)
                nextInChain.Calculate(request);
            else
                Debug.Log ("Handling of request failed: " + request.calculationWanted);
        }
    }
}