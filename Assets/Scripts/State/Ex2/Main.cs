using UnityEngine;

namespace State.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var account = new Account("John Doe");

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(200.00);
        }
    }
}