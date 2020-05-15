using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Adapter
{
    public class MotorElectrico
    {
        public string conectar()
        {
            return "Conectando Motor Electrico";
        }

        public string activar()
        {
            return "Activando Motor Electrico";
        }

        public string moverMasRapido()
        {
            return "Moviendo mas rapido el Motor";
        }

        public string detener()
        {
            return "Deteniendo Motor Electrico";
        }

        public string desconectar()
        {
            return "Desconectar Motor Electrico";
        }
    }
}
