using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Facade
{
    public class Pedidos
    {
        public int precioProducto(Comprador comprador)
        {
            return 10;
        }

        public int comisionPedido(Vendedor vendedor)
        {
            return 5;
        }
    }
}
