using UnityEngine;

namespace ChainOfResponsibility.Ex2
{
    public class DivideNumbers : IChain
    {
        protected IChain nextInChain;
		
        public void SetNextChain(IChain nextChain)
        {
            this.nextInChain = nextChain;
        }
		
        public void Calculate(Numbers request)
        {
            if(request.calculationWanted == CalculationType.Divide)
            {
                Debug.Log("Dividing: " + request.number1 + " / " + request.number2 + " = " + (request.number1 / request.number2).ToString());
            }
            else if(nextInChain != null)
                nextInChain.Calculate(request);
            else
                Debug.Log ("Handling of request failed: " + request.calculationWanted);
        }
    }
}