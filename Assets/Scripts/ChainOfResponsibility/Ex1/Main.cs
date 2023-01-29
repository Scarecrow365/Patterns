using UnityEngine;

namespace ChainOfResponsibility.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Executor senior = new Senior();
            Executor middle = new Middle();
            Executor junior = new Junior();

            senior.TransferIssue(middle);
            middle.TransferIssue(junior);

            Issue p = new(2034, 350.00, "Change number");
            senior.ProcessRequest(p);
        }
    }
}