using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Decorator
{
    public class CuentaCorriente : ICuentaBancaria
    {
        public string abrirCuenta(Cuenta c)
        {
            return "Se creo Cuenta Corriente";
        }
    }
}
