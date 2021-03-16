namespace Prototype.Ex3
{
    public class CloneFactory
    {
        public IAnimal GetClone(IAnimal animalPrototype)
        {
            return (IAnimal)animalPrototype.Clone();
        }
    }
}