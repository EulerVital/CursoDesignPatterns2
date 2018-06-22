using CursoDesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public int Num { get; private set; }

        public Numero(int valor)
        {
            this.Num = valor;
        }

        public int Avalia()
        {
            return this.Num;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
