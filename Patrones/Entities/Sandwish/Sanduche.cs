using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities.Sandwish
{
    public class Sanduche : SanduchePrototype
    {
        private string Pan;
        private string Carne;
        private string Queso;
        private string Vegetales;



        public Sanduche(string pan, string carne, string queso, string vegetales )
        {
            Pan = pan;
            Carne = carne;
            Queso = queso;
            Vegetales = vegetales;
        }

        public string getIngredientes()
        {
            string ingredientes = Pan +" ,"+ Carne + " ," + Queso + " ," + Vegetales;
            return ingredientes;
        }

        public override SanduchePrototype Clone()
        {
            string ingredientes = getIngredientes();

            return MemberwiseClone() as SanduchePrototype;
        }
    }

    public class SanducheMenu
    {
        private Dictionary<string, SanduchePrototype> _sandwiches = new Dictionary<string, SanduchePrototype>();

        public SanduchePrototype this[string name]
        {
            get { return _sandwiches[name]; }
            set { _sandwiches.Add(name, value); }
        }
    }
}
