using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando pedido do cliente {0}, com valor de R${1}", pedido.Cliente, pedido.Valor);
            pedido.Pago();
        }
    }
}
