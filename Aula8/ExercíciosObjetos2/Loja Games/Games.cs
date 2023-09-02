using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos2.Loja_Games
{
    public class Games : Produto
    {

        
        private string classificacao;
        private string comentario;

        public Games(
                string classificacao, string comentario, string nome, decimal preco, string notas, string descricao, string marca) 
                : base(nome, preco, notas, descricao, marca)
        {
            this.classificacao = classificacao;
            this.comentario = comentario;
        }
        public string GetClassificacao()
        {
            return classificacao;
        }

        public void SetClassificacao(string classificacao)
        {
            this.classificacao = classificacao ;
        }


        public string GetComentario()
        {
            return comentario;
        }

        public void SetComentario(string comentario)
        {
            this.comentario = comentario;
        }
        public override void Visualizar()
        {


            base.Visualizar();
            Console.WriteLine($"Classificação {this.classificacao}");
            Console.WriteLine($"Comentario {this.comentario}");
           
        }
    }
}

    
   