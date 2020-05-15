using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Composite
{
    public abstract class Componente
    {
        string nombre { get; set; }

        public Componente (string n)
        {
            nombre = n;
        }

        public abstract void AgregarHijo(Componente c);

        public abstract IList<Componente> ObtnerHijos();
        public abstract int ObtenerTamaño { get; }

    }
}
