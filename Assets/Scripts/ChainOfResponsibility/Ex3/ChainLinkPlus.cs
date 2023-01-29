using UnityEngine;

namespace ChainOfResponsibility.Ex3
{
    internal class ChainLinkPlus : BaseChainLink
    {
        public override void HandleRequest(int num1, int num2)
        {
            int newNum1 = num1 + num1;
            int newNum2 = num2 + num2;
            
            Debug.Log($"{GetType().Name} handled request {num1} + {num1} = {newNum1} & {num2} + {num2} = {newNum2}");
            successor?.HandleRequest(newNum1, newNum2);
        }
    }
}