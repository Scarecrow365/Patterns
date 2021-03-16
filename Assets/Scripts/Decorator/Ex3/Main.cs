using System;
using UnityEngine;

namespace Assets.Scripts.Decorator.Ex3
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            IPizza pizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
            Debug.Log(pizza.GetCost());
            Debug.Log(pizza.GetDescription());
        }
    }
}