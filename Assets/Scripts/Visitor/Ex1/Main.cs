using System.Collections;
using UnityEngine;

namespace Visitor.Ex1
{
    public class Main : MonoBehaviour
    {
        private IEnumerator Start()
        {
            IRobotPart robot = new Robot();
            robot.Accept(gameObject.AddComponent<RobotActivateVisitor>());

            yield return new WaitForSeconds(2);

            robot.Accept(gameObject.AddComponent<RobotDeactivateVisitor>());
        }
    }
}