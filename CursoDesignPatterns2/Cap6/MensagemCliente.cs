using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string nome;

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public IEnviador Enviador { get; set; }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o clinete {0}", nome);
        }
    }
}
