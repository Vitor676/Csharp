using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos2.Loja_Games
{
    public class Produto 
    {
       
        private string nome;
        private decimal preco;
        private string notas;
        private string descricao;
        private string marca;

        public Produto(string nome, decimal preco, string notas, string descricao, string marca)
        {
            this.nome = nome;
            this.preco = preco;
            this.notas = notas;
            this.descricao = descricao;
            this.marca = marca;
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }


        public decimal Getpreco()
        {
            return preco;
        }

        public void Setpreco(decimal preco)
        {
            this.preco = preco;
        }

        public string Getnotas()
        {
            return notas;
        }

        public void Setnota(string notas)
        {
            this.notas = notas;
        }
        public string GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }


        public virtual void Visualizar()
        {


            Console.WriteLine("****************************");
            Console.WriteLine("Loja do JooJ");
            Console.WriteLine("****************************");
            Console.WriteLine($"Nome do Produto {this.nome}");
            Console.WriteLine($"Preço do Produto {this.preco}");
            Console.WriteLine($"Notas do Produto {this.notas}");
            Console.WriteLine($"Descrição do Produto {this.descricao}");
            Console.WriteLine($"Marca do Produto {this.marca}");
        }
    }

}
