using UnityEngine;

namespace Factory.Ex1
{
    public class ConcreteFactoryA : Factory
    {
        public override IProduct GetProduct(Vector3 position)
        {
            ProductA newProduct = new GameObject()
                .AddComponent<ProductA>();
            
            newProduct.Initialize();
            return newProduct;
        }
    }
}