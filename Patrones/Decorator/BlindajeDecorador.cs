using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Decorator
{
    public class BlindajeDecorador : CuentaDecorador
    {

        public BlindajeDecorador( ICuentaBancaria cuentaBancaria) :base(cuentaBancaria)
        {

        }

        public override string abrirCuenta(Cuenta c)
        {
            return _cuentaDecorada.abrirCuenta(c) + AgregarBlindaje();
        }

        public string AgregarBlindaje()
        {
            return "Se Agrego Blindaje a su cuenta";
        }
    }
}
