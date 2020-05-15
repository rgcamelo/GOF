using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Entities
{
    public class ParedConDañodeExplosion : Pared
    {
        public override string Entrar()
        {
            return "Te has Golpeado con una pareda dañada por una Explosion";
        }
    }
}
