using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;
namespace Patrones.FactoryMethod
{
    public abstract class FactoryPuerta
    {
        public Puerta puerta;
        public abstract Puerta FactoryMethod(Habitacion h1, Habitacion h2);

    }
}
