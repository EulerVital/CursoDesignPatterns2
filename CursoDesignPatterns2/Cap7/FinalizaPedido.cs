using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public Pedido pedido { get; private set; }

        public void Executa()
        {
            Console.WriteLine("Finalizando pedido do cliente {0}, com valor de R${1}", pedido.Cliente, pedido.Valor);
            pedido.Finaliza();
        }
    }
}
