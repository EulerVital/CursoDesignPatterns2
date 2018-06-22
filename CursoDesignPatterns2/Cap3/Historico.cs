using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class Historico
    {
        private IList<Estado> Estado = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estado.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return Estado[indice];
        }
    }
}
