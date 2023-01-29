using UnityEngine;

namespace ChainOfResponsibility.Ex3
{
    internal class ChainLinkDivide : BaseChainLink
    {
        public override void HandleRequest(int num1, int num2)
        {
            Debug.Log($"{GetType().Name} handled request {num2} / {num1} = {num2 / num1}");
            successor?.HandleRequest(num1, num2);
        }
    }
}