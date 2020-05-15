using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Bridge
{
    public class RepartoAmazon : Amazon
    {
        private string numPedido;

        public RepartoAmazon(string npedido, InterfaceEnvio interfaceEnvio ): base(interfaceEnvio)
        {
            numPedido = npedido;
        }


    }
}
