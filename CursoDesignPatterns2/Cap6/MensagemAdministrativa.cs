using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public IEnviador Enviador{ get; set; }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem a administrativa para {0}", nome);
        }
    }
}
