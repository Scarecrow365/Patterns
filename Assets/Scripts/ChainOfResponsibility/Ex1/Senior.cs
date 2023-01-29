using UnityEngine;

namespace ChainOfResponsibility.Ex1
{
    internal class Senior : Executor
    {
        public override void ProcessRequest(Issue issue)
        {
            Debug.Log($"{GetType().Name} approved request# {issue.Number} - {issue.Amount} - {issue.Purpose}");
            Successor?.ProcessRequest(issue);
        }
    }
}