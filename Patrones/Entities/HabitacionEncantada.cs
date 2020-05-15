using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    class HabitacionEncantada : Habitacion
    {
        public HabitacionEncantada ( int numhabitacion ) : base(numhabitacion)
        {
            _numeroHabitacion = numhabitacion;
        }

        public override string Entrar()
        {
            return($" Habitacion Encantada :{_numeroHabitacion}");
        }
    }
}
