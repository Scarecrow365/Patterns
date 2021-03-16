using UnityEngine;

namespace Facade.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var facade = new BankAccountFacade(98651, 2465);

            print(facade.WithdrawCash(1243));

            print(facade.DepositCash(124));
        }
    }
}