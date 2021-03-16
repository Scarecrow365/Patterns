using System;

namespace Prototype.Ex3
{
    public class Sheep : IAnimal
    {
        public object Clone()
        {
            Sheep sheep;

            try
            {
                sheep = (Sheep)MemberwiseClone();
            }
            catch (Exception e)
            {
                sheep = null;
            }

            return sheep;
        }
    }
}