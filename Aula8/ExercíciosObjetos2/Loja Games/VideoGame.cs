using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos2.Loja_Games
{
    public class VideoGame : Produto
    {

        private string tipodeConsole;
        private string anodelancamento;
        public VideoGame(string nome, decimal preco, string notas, string descricao, string marca, string tipodeConsole, string anodelancamento) : base(nome, preco, notas, descricao, marca)
        {
            this.tipodeConsole = tipodeConsole;
            this.anodelancamento = anodelancamento;
        }
        public string GetTipodeConsole()
        {
            return tipodeConsole;
        }

        public void SetTipodeConsole(string tipodeConsole)
        {
            this.tipodeConsole = tipodeConsole;
        }
        public string GetanodeLancamento()
        {
            return anodelancamento;
        }

        public void SetanodeLancamento(string anodelancamento)
        {
            this.anodelancamento = anodelancamento;
        }
        public override void Visualizar()
        {


            base.Visualizar();
            Console.WriteLine($"Tipo do Console {this.tipodeConsole}");
            Console.WriteLine($"Ano de Lançamento do Console {this.anodelancamento}");
            

        }
    }
}
