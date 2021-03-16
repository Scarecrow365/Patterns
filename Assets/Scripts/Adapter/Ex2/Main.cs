using UnityEngine;

namespace Adapter.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            IEnemyAttacker tank = new Tank();

            var fredTheRobot = new Robot();
            IEnemyAttacker adapter = new Adapter(fredTheRobot);

            fredTheRobot.SetDriver("Hans");
            fredTheRobot.MoveForward();

            tank.AssignDriver("Frank");
            tank.DriveForward();
            tank.Fire();

            adapter.AssignDriver("Mark");
            adapter.DriveForward();
            adapter.Fire();
        }
    }
}