using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Adapter
{
    public class MotorComun : Motor
    {
        public override string Acelerar()
        {
            return "Acelerando Motor comun";
        }

        public override string Apagar()
        {
            return "Apagando Motor Comun";
        }

        public override string Encender()
        {
            return "Encendiendo Motor Comun";
        }
    }
}
