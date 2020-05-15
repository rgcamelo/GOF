using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Composite
{
    public class Archivo : Componente
    {
        int _tamaño { get; }

        public Archivo(string n, int tamaño) : base(n)
        {
            _tamaño = tamaño;
        }
        public override int ObtenerTamaño { 
            get { 
                return _tamaño; 
            } 
        }

        public override void AgregarHijo(Componente c)
        {
            
        }

        public override IList<Componente> ObtnerHijos()
        {
            return null;
        }
    }
}
