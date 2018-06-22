using CursoDesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap5
{
    public class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("-");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Num);
        }
    }
}
