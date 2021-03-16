using UnityEngine;

namespace Prototype.Ex2
{
    public class Main : MonoBehaviour
    {
        private ColorManager _colorManager = new ColorManager();

        private void Start()
        {
            _colorManager["red"] = new Color(255, 0, 0);
            _colorManager["green"] = new Color(0, 255, 0);
            _colorManager["blue"] = new Color(0, 0, 255);
            
            _colorManager["angry"] = new Color(255, 54, 0);
            _colorManager["peace"] = new Color(128, 211, 128);
            _colorManager["flame"] = new Color(211, 34, 20);
            
            var color1 = _colorManager["red"].Clone() as Color;
            var color2 = _colorManager["peace"].Clone() as Color;
            var color3 = _colorManager["flame"].Clone() as Color;

            Debug.Log(color1);
            Debug.Log(color2);
            Debug.Log(color3);
        }
    }
}