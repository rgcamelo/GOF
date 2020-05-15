using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Bridge
{
    public class EnviarPortugal : InterfaceEnvio
    {
        public string entregar()
        {
            return "Pedido entregado a Portugal";
        }

        public string enviar()
        {
            return "Pedido enviado a Portugal";
        }

        public string procesarPedido()
        {
            return "Pedido procesado para Portugal";
        }
    }
}
