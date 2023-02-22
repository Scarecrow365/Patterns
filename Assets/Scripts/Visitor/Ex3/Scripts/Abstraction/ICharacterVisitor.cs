using Visitor.Ex3.Scripts.Characters;

namespace Visitor.Ex3.Scripts.Abstraction
{
    public interface ICharacterVisitor<T>
    {
        T Visit(Archer archer);

        T Visit(Paladin paladin);

        T Visit(Mage mage);
    }
}