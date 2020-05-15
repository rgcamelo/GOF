using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        private MotorElectrico motorElectrico;

        public MotorElectricoAdapter()
        {
            motorElectrico = new MotorElectrico();
        }
        public override string Acelerar()
        {
            motorElectrico.moverMasRapido();
            return "Acelerando Motor Electrico";
        }

        public override string Apagar()
        {
            motorElectrico.detener();
            motorElectrico.desconectar();

            return "Apagando Motor Electrico";
        }

        public override string Encender()
        {
            motorElectrico.conectar();
            motorElectrico.activar();

            return "Encendiendo Motor Electrico";
        }
    }
}
