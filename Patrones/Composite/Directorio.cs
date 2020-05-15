using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Composite
{
    public class Directorio : Componente
    {
        private List<Componente> _hijos;

        public Directorio(string n) : base(n)
        {
            _hijos = new List<Componente>();
        }
        public override int ObtenerTamaño
        {
            get{
                int t = 0;

                foreach ( var item in _hijos)
                {
                    t += item.ObtenerTamaño;
                }

                return t;
            }
        }

        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtnerHijos()
        {
            return _hijos.ToArray();
        }
    }
}
