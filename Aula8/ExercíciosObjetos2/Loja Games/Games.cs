using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos2.Loja_Games
{
    public class Games
    {

        private string nome;
        private string classificação;
        private int preço;
        private int notas;
        private string comentario;

        public Games(string nome, string classificação, int preço, int notas, string comentario)
        {
            this.nome = nome;
            this.classificação = classificação;
            this.preço = preço;
            this.notas = notas;
            this.comentario = comentario;
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string Getclassificação()
        {
            return classificação;
        }

        public void Setclassificação(string classificação)
        {
            this.classificação = classificação;
        }

        public int Getpreço()
        {
            return preço;
        }

        public void Setpreço(int preço)
        {
            this.preço = preço;
        }

        public int Getnotas()
        {
            return notas;
        }

        public void Setnota(int notas)
        {
            this.notas = notas;
        }

        public string Getcomentario()
        {
            return comentario;
        }

        public void Setcomentario(string comentario)
        {
            this.comentario = comentario;
        }


        public void Visualizar()
        {


            Console.WriteLine("****************************");
            Console.WriteLine("Loja do JooJ");
            Console.WriteLine("****************************");
            Console.WriteLine($"Nome do Jogo {this.nome}");
            Console.WriteLine($"Classificação do Jogo {this.classificação}");
            Console.WriteLine($"Preço do Jogo {this.preço}");
            Console.WriteLine($"Notas do Jogo {this.notas}");
            Console.WriteLine($"Comentarios do Jogo {this.comentario}");
        }

    }
}

    
   