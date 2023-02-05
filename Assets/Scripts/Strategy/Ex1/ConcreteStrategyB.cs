using UnityEngine;

namespace Strategy.Ex1
{
    internal class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}