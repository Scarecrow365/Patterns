using UnityEngine;

namespace ChainOfResponsibility.Ex1
{
    internal class Junior : Executor
    {
        public override void ProcessRequest(Issue issue)
        {
            issue.Amount = 0;
            Debug.Log($"{GetType().Name} approved request# {issue.Number} - {issue.Amount} - {issue.Purpose}");
            Successor?.ProcessRequest(issue);
        }
    }
}