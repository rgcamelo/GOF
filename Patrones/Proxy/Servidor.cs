using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Proxy
{
    public abstract class Servidor
    {
        public abstract string descargar(string url);
    }
}
