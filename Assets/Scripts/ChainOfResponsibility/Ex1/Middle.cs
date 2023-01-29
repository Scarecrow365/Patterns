using UnityEngine;

namespace ChainOfResponsibility.Ex1
{
    internal class Middle : Executor
    {
        public override void ProcessRequest(Issue issue)
        {
            issue.Amount *= 2;
            Debug.Log($"{GetType().Name} approved request# {issue.Number} - {issue.Amount} - {issue.Purpose}");
            Successor?.ProcessRequest(issue);
        }
    }
}