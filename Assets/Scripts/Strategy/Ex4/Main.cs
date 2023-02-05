using UnityEngine;

namespace Strategy.Ex4
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Missile sideWinder = new SideWinder();
            sideWinder.ApplySeek();

            Missile tomahawk = new Tomahawk();
            tomahawk.ApplySeek();

            Missile torpedo = new Torpedo();
            torpedo.ApplySeek();

            Missile sideWinderWithSonar = new SideWinder();
            ISeekBehaviour sonar = new SeekWithSonar();
            sideWinderWithSonar.SetSeekBehavior(sonar);
            sideWinderWithSonar.ApplySeek();
        }
    }
}