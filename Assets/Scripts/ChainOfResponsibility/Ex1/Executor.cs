namespace ChainOfResponsibility.Ex1
{
    internal abstract class Executor
    {
        protected Executor Successor;

        public void TransferIssue(Executor successor)
        {
            Successor = successor;
        }

        public abstract void ProcessRequest(Issue issue);
    }
}