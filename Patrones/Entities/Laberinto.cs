using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    public class Laberinto
    {
        public List<Habitacion> Habitaciones { get; set; }
        public Laberinto()
        {
            Habitaciones = new List<Habitacion>();
        }

        public Habitacion BuscarHabitacion(int numerohabitacion)
        {
            Habitacion habitacion = Habitaciones.Find(h => h._numeroHabitacion == numerohabitacion);
            return habitacion;
        }

        public void AñadirHabitacion(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }
    }
}
