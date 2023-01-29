using UnityEngine;

namespace Mediator.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Mediator mediator = new();

            MainColleague mainColleague = new(mediator);
            SecondaryColleague secondaryColleague = new(mediator);

            mediator.Colleague1 = mainColleague;
            mediator.Colleague2 = secondaryColleague;

            mainColleague.Send("How are you?");
            secondaryColleague.Send("Fine, thanks");
        }
    }
}