using UnityEngine;

namespace Strategy.Ex1
{
    internal class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}