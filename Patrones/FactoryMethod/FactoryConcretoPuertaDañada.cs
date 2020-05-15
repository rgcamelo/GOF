using Patrones.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.FactoryMethod
{
    public class FactoryConcretoPuertaDañada : FactoryPuerta
    {
        public override Puerta FactoryMethod(Habitacion h1, Habitacion h2)
        {
            puerta = new PuertaDañada(h1, h2);
            return puerta;
        }
    }
}
