using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    public class PuertaDañada : Puerta
    {
        public PuertaDañada (Habitacion h1, Habitacion h2): base(h1, h2)
        {
            _habitacion1 = h1;
            _habitacion2 = h2;
        }

        public override string Entrar()
        {
            return "Pasando Por Puerta Dañada" + _habitacion2.Entrar();
        }

    }
}
