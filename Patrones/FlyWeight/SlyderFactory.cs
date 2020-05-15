using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.FlyWeight
{
    public class SliderFactory
    {
        private Dictionary<char, Slider> _sliders =
            new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (_sliders.ContainsKey(key)) 
            {
                slider = _sliders[key];
            }
            else 
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }
}
