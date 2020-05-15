using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Decorator
{
    public abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria _cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            _cuentaDecorada = cuentaDecorada;
        }
        public virtual string abrirCuenta(Cuenta c)
        {
          return _cuentaDecorada.abrirCuenta(c);
        }
    }
}
