using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Singleton
{
    public sealed class Cocina
    {
        private static readonly Cocina instance = new Cocina();

        static Cocina()
        {
        }

        private Cocina()
        {
        }

        public static Cocina Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
