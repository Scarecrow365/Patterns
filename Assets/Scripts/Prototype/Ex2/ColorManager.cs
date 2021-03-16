using System.Collections.Generic;

namespace Prototype.Ex2
{
    public class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}