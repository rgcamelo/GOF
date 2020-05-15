using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.FlyWeight
{
    public abstract class Slider
    {
        protected string Name;
        protected string Cheese;
        protected string Toppings;
        protected decimal Price;

        public abstract string Display(int orderTotal);
    }
}
