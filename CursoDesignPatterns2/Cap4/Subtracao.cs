using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns2.Cap5;

namespace CursoDesignPatterns2.Cap4
{
    public class Subtracao : IExpressao
    {

        public IExpressao Direita { get; private set; }
        public IExpressao Esquerda { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireirta = Direita.Avalia();
            return valorEsquerda - valorDireirta;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
