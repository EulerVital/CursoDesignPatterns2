using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap3;
using CursoDesignPatterns2.Cap4;
using CursoDesignPatterns2.Cap5;
using CursoDesignPatterns2.Cap6;
using CursoDesignPatterns2.Cap7;
using CursoDesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CursoDesignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };

            Piano piano = new Piano();
            piano.Toca(musica);

            //Memento
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Euler Vital", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());
            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.Tipo);
            Console.WriteLine(historico.Pega(2).Contrato.Tipo);
            Console.ReadLine();

            //Interpreter
            //((1 + 100) + 10) + (20 - 10)
            //Pode ser usado toda vezque nós temos uma arvore de expressoes que queremos avaliar
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);
            Console.WriteLine(soma.Avalia());

            //API Expression do C#
            Expression soma_01 = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma_01).Compile();
            Console.WriteLine(funcao());

            //Visitor
            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

            //Bridge (Separa responsabilidade)
            IMensagem mensagem = new MensagemCliente("Euler");
            mensagem.Enviador = new EnviaPorEmail();
            mensagem.Envia();
            Console.ReadLine();

            //Command
            //OBS: Ideal para api´s que serão consumidas por celulares
            //Pois pode ser excutado posteriormente
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Euler", 120.90);
            Pedido pedido2 = new Pedido("Jean", 110.90);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));
            fila.Processa();


            //Adpter
            //Usado para aptar o codigo usado pela biblioteca nativa c#
            Cliente cliente = new Cliente();
            cliente.Nome = "Euler";
            cliente.Endereco = "Rua vergueiro";
            cliente.DataDeNascimento = DateTime.Now;
            string xml  = new GeradorDeXml().GeraXml(cliente);
            Console.WriteLine(xml);
            Console.ReadLine();

        }
    }
}
