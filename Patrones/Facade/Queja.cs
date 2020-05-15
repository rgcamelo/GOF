using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Facade
{
    public class Quejas
    {
        public string quejas(Comprador comprador)
        {
            return "Escuchando queja de comprador";
        }

        public string quejas(Vendedor vendedor)
        {
            return "Escuchando queja de vendedor";
        }

        public string quejas(Desarrollador desarrollador)
        {
            return "Escuchando queja de desarrollador";
        }
    }
}
