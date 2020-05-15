using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Bridge
{
    public class EnviarColombia : InterfaceEnvio
    {
        public string entregar()
        {
            return "Pedido Entregado a Colombia";
        }

        public string enviar()
        {
            return "Pedido Enviado a Colombia";
        }

        public string procesarPedido()
        {
            return "Pedido Procesado para Colombia";
        }
    }
}
