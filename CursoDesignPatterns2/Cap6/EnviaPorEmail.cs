using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    public class EnviaPorEmail : IEnviador
    {

        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("");
            Console.WriteLine("Mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
