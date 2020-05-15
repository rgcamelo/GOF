using System;
using System.Collections.Generic;
using System.Text;
using Patrones.AbstractFactory;
using Patrones.Builder;

namespace Patrones.Entities
{
    public class JuegoDelLaberinto
    {
        public JuegoDelLaberinto()
        {

        }

        public Laberinto CrearLaberinto()
        {
            Laberinto laberinto = new Laberinto();

            Habitacion h1 = new Habitacion(1);
            Habitacion h2 = new Habitacion(2);

            laberinto.AñadirHabitacion(h1);
            laberinto.AñadirHabitacion(h2);

            Puerta puerta = new Puerta(h1, h2);

            h1.EstablecerLado((Direccion)0, new Pared());
            h1.EstablecerLado((Direccion)1, puerta);
            h1.EstablecerLado((Direccion)2, new Pared());
            h1.EstablecerLado((Direccion)3, new Pared());

            h2.EstablecerLado((Direccion)0, new Pared());
            h2.EstablecerLado((Direccion)1, new Pared());
            h2.EstablecerLado((Direccion)2, new Pared());
            h2.EstablecerLado((Direccion)3, puerta);

            return laberinto;
        }

        public Laberinto CrearLaberinto(ConstructorLaberinto constructor)
        {
            constructor.ConstruirLaberinto();
            Laberinto laberinto = constructor.ObtenerLaberinto();

            return laberinto;
        }

        public Laberinto CrearLaberinto(FabricadeLaberintos fabrica)
        {
            Laberinto laberinto = fabrica.HacerLaberinto();
            Habitacion h1 = fabrica.HacerHabitacion(1);
            Habitacion h2 = fabrica.HacerHabitacion(2);
            Puerta puerta = fabrica.HacerPuerta(h1, h2);

            laberinto.AñadirHabitacion(h1);
            laberinto.AñadirHabitacion(h2);

            h1.EstablecerLado(0, fabrica.HacerPared());
            h1.EstablecerLado((Direccion)1, puerta);
            h1.EstablecerLado((Direccion)2, fabrica.HacerPared());
            h1.EstablecerLado((Direccion)3, fabrica.HacerPared());

            h2.EstablecerLado((Direccion)0, fabrica.HacerPared());
            h2.EstablecerLado((Direccion)0, fabrica.HacerPared());
            h2.EstablecerLado((Direccion)0, fabrica.HacerPared());
            h2.EstablecerLado((Direccion)0, puerta);

            return laberinto;
        }
    }
}
