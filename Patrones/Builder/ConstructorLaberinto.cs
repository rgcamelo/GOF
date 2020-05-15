using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;
namespace Patrones.Builder
{
    public abstract class ConstructorLaberinto
    {
        public abstract void ConstruirLaberinto();
        public abstract void ConstruirHabitacion(int numHabitacion);

        public abstract void ConstruirPuerta(int habitacion1, int habitacion2, Direccion ph1, Direccion ph2);

        public abstract Laberinto ObtenerLaberinto();

    }
}
