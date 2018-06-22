using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataFinalizado { get; set; }
        public Status Status { get; private set; }

        public Pedido(string nome, double valor)
        {
            this.Valor = valor;
            this.Cliente = nome;
            this.Status = Status.Novo;
        }

        public void Pago()
        {
            this.Status = Status.Pago;
        }

        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataFinalizado = DateTime.Now;
        }
    }
}
