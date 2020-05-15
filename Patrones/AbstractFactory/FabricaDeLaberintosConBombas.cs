using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;

namespace Patrones.AbstractFactory
{
    public class FabricaDeLaberintosConBombas : FabricadeLaberintos
    {
        public override Habitacion HacerHabitacion(int n)
        {
            return new HabitacionConBomba(n);
        }

        public override Pared HacerPared()
        {
            return new ParedConDañodeExplosion();
        }
    }
}
