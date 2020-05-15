using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Proxy
{
    public class MiServidor : Servidor
    {
        private int puerto;
        private string host;

        public MiServidor(int p, string h)
        {
            puerto = p;
            host = h;
        }

        public override string descargar(string url)
        {
            return "Descargando de :" + host;
        }
    }
}
