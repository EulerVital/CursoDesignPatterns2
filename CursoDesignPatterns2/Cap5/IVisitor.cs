using CursoDesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }
}
