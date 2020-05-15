using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Adapter
{
    public abstract class Motor
    {
        public abstract string Encender();
        public abstract string Acelerar();
        public abstract string Apagar();
    }
}
