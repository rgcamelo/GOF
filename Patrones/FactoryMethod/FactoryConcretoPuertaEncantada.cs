using Patrones.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;

namespace Patrones.FactoryMethod
{
    public class FactoryConcretoPuertaEncantada : FactoryPuerta
    {
        public override Puerta FactoryMethod( Habitacion h1, Habitacion h2)
        {
            puerta = new PuertaEncantada(h1, h2);
            return puerta;
        }
    }
}
