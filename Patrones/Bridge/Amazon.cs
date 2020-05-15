using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Bridge
{
    public abstract class Amazon
    {
        protected InterfaceEnvio interfaceEnvio;

        public Amazon(InterfaceEnvio interfaz)
        {
            interfaceEnvio = interfaz;
        }


        public string procesarPedido()
        {
            return interfaceEnvio.entregar();
        }

        public string enviarPedido()
        {
            return interfaceEnvio.enviar();
        }

        public string entregarPedido()
        {
            return interfaceEnvio.entregar();
        }

        public void asignarEnvio(InterfaceEnvio interfaz)
        {
            interfaceEnvio = interfaz;
        }

        public InterfaceEnvio obtenerEnvio()
        {
            return interfaceEnvio;
        }
    }
}
