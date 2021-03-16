namespace Prototype.Ex2
{
    public class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;
        }
    }
}