using UnityEngine;

namespace Strategy.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Unit sparky = new Dog();
            Unit tweety = new Bird();

            Debug.Log("Dog: " + sparky.TryToFly());
            Debug.Log("Bird: " + tweety.TryToFly());

            sparky.SetFlyingAbility(new FlyStrategy());
            tweety.SetFlyingAbility(new QuickFlyStrategy());

            Debug.Log("Dog: " + sparky.TryToFly());
            Debug.Log("Bird: " + tweety.TryToFly());
        }
    }
}
