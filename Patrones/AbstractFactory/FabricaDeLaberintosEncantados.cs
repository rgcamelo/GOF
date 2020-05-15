using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;

namespace Patrones.AbstractFactory
{
    public class FabricaDeLaberintosEncantados : FabricadeLaberintos
    {


        public override Habitacion HacerHabitacion(int n)
        {
            return new HabitacionEncantada(n);
        }

        public override Puerta HacerPuerta(Habitacion h1, Habitacion h2)
        {
            return new PuertaEncantada(h1,h2);
        }
    }
}
