using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones.Facade
{
    public class Empresa
    {
        public Quejas quejas;
        public Pedidos pedidos;

        public Empresa()
        {
            quejas = new Quejas();
            pedidos = new Pedidos();
        }

        private string quejasComprador (Comprador comprador)
        {
            return quejas.quejas(comprador);
        }

        private string quejasVendedor(Vendedor vendedor)
        {
            return quejas.quejas(vendedor);
        }

        private string quejasDesarrollador(Desarrollador desarrollador)
        {
            return quejas.quejas(desarrollador);
        }

        public string escucharQuejas(Persona persona)
        {
            if(persona is Comprador)
            {
               return quejasComprador((Comprador)persona);
            }
            else if(persona is Vendedor){
                return quejasVendedor((Vendedor)persona);
            }
            else
            {
                return quejasDesarrollador((Desarrollador)persona);
            }
        }

        public int hacerPedido(Vendedor vendedor, Comprador comprador)
        {
            return pedidos.comisionPedido(vendedor) + pedidos.precioProducto(comprador);
        }
    }
}
