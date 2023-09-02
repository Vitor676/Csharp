using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercíciosObjetos1.Classe
{
    public class Cliente
    {
        private string nome;
        private float altura;
        private int idade;
        private string cordoCabelo;
        private string sexo;

        public Cliente(string nome, float altura, int idade, string cordoCabelo, string sexo)
        {
            this.nome = nome;
            this.altura = altura;
            this.idade = idade;
            this.cordoCabelo = cordoCabelo;
            this.sexo = sexo;
        }
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public float GetAltura()
        {
            return altura;
        }

        public void SetAltura(float altura)
        {
            this.altura = altura;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetCordoCabelo()
        {
            return cordoCabelo;
        }

        public void SetCordoCabelo(string cordoCabelo)
        {
            this.cordoCabelo = cordoCabelo;
        }

        public string GetSexo()
        {
            return sexo;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }
        

        public virtual void Visualizar()
        {
            

            Console.WriteLine("****************************");
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine("****************************");
            Console.WriteLine($"Nome do Cliente {this.nome}");
            Console.WriteLine($"Altura do Cliente {this.altura}");
            Console.WriteLine($"Idade do Cliente {this.idade}");
            Console.WriteLine($"Cor do Cabelo do Cliente {this.cordoCabelo}");
            Console.WriteLine($"Sexo do Cliente {this.sexo}");
        }

    }
}

    

