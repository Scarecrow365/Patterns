using UnityEngine;

namespace State.Ex1
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var ship = new Ship();

            ship.ChangeState(new NormalShipState());

            Debug.Log($"Change ship state on {ship.CurrentState}");

            ship.ChangeState(new AlertShipState());

            Debug.Log($"Change ship state on {ship.CurrentState}");

            ship.ChangeState(new DisabledShipState());

            Debug.Log($"Change ship state on {ship.CurrentState}");
        }
    }
}