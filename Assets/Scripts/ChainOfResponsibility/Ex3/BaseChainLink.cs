namespace ChainOfResponsibility.Ex3
{
    internal abstract class BaseChainLink
    {
        protected BaseChainLink successor;

        public void SetSuccessor(BaseChainLink successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int num1, int num2);
    }
}