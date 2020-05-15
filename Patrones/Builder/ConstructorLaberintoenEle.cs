using System;
using System.Collections.Generic;
using System.Text;
using Patrones.Entities;

namespace Patrones.Builder
{
    public class ConstructorLaberintoenEle : ConstructorLaberinto
    {
        Laberinto laberinto;
        public ConstructorLaberintoenEle()
        {
            laberinto = new Laberinto();
        }
        public override void ConstruirHabitacion(int numHabitacion)
        {
            Habitacion habitacion = new Habitacion(numHabitacion);
            laberinto.AñadirHabitacion(habitacion);

            habitacion.EstablecerLado((Direccion)0, new Pared());
            habitacion.EstablecerLado((Direccion)1, new Pared());
            habitacion.EstablecerLado((Direccion)2, new Pared());
            habitacion.EstablecerLado((Direccion)3, new Pared());
        }

        public override void ConstruirLaberinto()
        {
            ConstruirHabitacion(1);
            ConstruirHabitacion(2);
            ConstruirHabitacion(3);
            ConstruirHabitacion(4);

            ConstruirPuerta(1, 2, (Direccion)2, (Direccion)0);
            ConstruirPuerta(2, 3, (Direccion)2, (Direccion)0);
            ConstruirPuerta(3, 4, (Direccion)1, (Direccion)3);

        }

        public override void ConstruirPuerta(int habitacion1, int habitacion2, Direccion ph1, Direccion ph2)
        {
            Habitacion h1 = laberinto.BuscarHabitacion(habitacion1);
            Habitacion h2 = laberinto.BuscarHabitacion(habitacion2);

            Puerta p = new Puerta(h1, h2);

            h1.EstablecerLado(ph1, p);
            h2.EstablecerLado(ph2, p);
        }

        public override Laberinto ObtenerLaberinto()
        {
            ConstruirLaberinto();
            return laberinto;
        }

        public override string ObtenerNombre()
        {
            return "Laberinto en Ele";
        }
    }
}
