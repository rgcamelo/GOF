using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;

namespace Patrones.AbstractFactory
{
    public class FabricadeLaberintos
    {
        public virtual Laberinto HacerLaberinto()
        {
            return new Laberinto();
        }

        public virtual Habitacion HacerHabitacion(int n)
        {
            return new Habitacion(n);
        }

        public virtual Pared HacerPared()
        {
            return new Pared();
        }

        public virtual Puerta HacerPuerta(Habitacion h1, Habitacion h2)
        {
            return new Puerta(h1, h2);
        }




    }
}
