using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    public class PuertaEncantada : Puerta
    {
        
        public PuertaEncantada( Habitacion h1, Habitacion h2) : base(  h1,  h2)
        {
            _habitacion1 = h1;
            _habitacion2 = h2;
        }

        public override string Entrar()
        {
            
            return "Pasando Por Puerta Encantada" + _habitacion2.Entrar();
         
        }


    }
}
