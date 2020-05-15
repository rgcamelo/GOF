using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Decorator
{
    public class CuentaAhorro : ICuentaBancaria
    {
        public string abrirCuenta(Cuenta c)
        {
            return "Se creo Cuenta de Ahorro";
        }
    }
}
