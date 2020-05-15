using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    class HabitacionConBomba : Habitacion
    {

        public HabitacionConBomba(int numhabitacion) : base(numhabitacion)
        {
            _numeroHabitacion = numhabitacion;
        }

        public override string Entrar()
        {
            return ($" Habitacion Con Bomba :{_numeroHabitacion}");
        }
    }
}
