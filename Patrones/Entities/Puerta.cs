using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    public class Puerta : LugarDelMapa
    {
        public Habitacion _habitacion1;
        public Habitacion _habitacion2;
        bool EstaAbierta = true;

        public Puerta(Habitacion h1, Habitacion h2)
        {
            _habitacion1 = h1;
            _habitacion2 = h2;
        }

        public Habitacion OtroLadoDe()
        {
            return _habitacion2;
        }
        public override string Entrar()
        {
            if (EstaAbierta)
            {
                
                return ("Pasando La Puerta")+ OtroLadoDe().Entrar(); 
                
            }
            else
            {
                return "Puerta Cerrada";
            }
        }

    }
}
