using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Decorator
{
    public class Cuenta
    {
        private int _id { get; set; }
        private string _nombre { get; set; }

        public Cuenta()
        {

        }

        public Cuenta( int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
    }
}
