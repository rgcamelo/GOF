using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Proxy
{
    public class ProxyMiServidor : Servidor
    {

        MiServidor miServidor;
        private int puerto;
        private string host;

        public ProxyMiServidor(int p, string h)
        {
            puerto = p;
            host = h;
            miServidor = null;
        }
        public override string descargar(string url)
        {
            string resultado = string.Empty;
            if (restringido(url))
            {
                if (miServidor == null)
                    miServidor = new MiServidor(puerto, host);

                resultado = miServidor.descargar(url);
            }
            else
            {
                resultado = "Desde esta ubicacion no puedes descargar";
            }

            return resultado;
        }

        public Boolean restringido(string ruta)
        {
            Boolean descargarPermitida = false;
            if(ruta == "descargaPermitida")
            {
                descargarPermitida = true;
                
            }
            return descargarPermitida;
        }
    }
}
