using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Bridge
{
    public interface InterfaceEnvio
    {
        string procesarPedido();
        string enviar();
        string entregar();
    }
}
