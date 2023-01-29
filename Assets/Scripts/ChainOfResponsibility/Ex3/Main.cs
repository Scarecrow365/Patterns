using UnityEngine;

namespace ChainOfResponsibility.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            const int num1 = 5;
            const int num2 = 10;
            
            BaseChainLink linkPlus = new ChainLinkPlus();
            BaseChainLink linkMinus = new ChainLinkMinus();
            BaseChainLink linkMultiple = new ChainLinkMultiple();
            BaseChainLink linkDivide = new ChainLinkDivide();

            linkPlus.SetSuccessor(linkMinus);
            linkMinus.SetSuccessor(linkMultiple);
            linkMultiple.SetSuccessor(linkDivide);

            linkPlus.HandleRequest(num1, num2);
        }
    }
}