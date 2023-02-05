using UnityEngine;

namespace Strategy.Ex1
{
    internal class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}