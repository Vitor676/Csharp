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
        private string cpf;
        private string sexo;

        public Cliente(string nome, float altura, int idade, string cpf, string sexo)
        {
            this.nome = nome;
            this.altura = altura;
            this.idade = idade;
            this.cpf = cpf;
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

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string  cpf)
        {
            this.cpf = cpf;
        }

        public string GetSexo()
        {
            return sexo;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }
        

        public void Visualizar()
        {
            

            Console.WriteLine("****************************");
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine("****************************");
            Console.WriteLine($"Nome do Cliente {this.nome}");
            Console.WriteLine($"Altura do Cliente {this.altura}");
            Console.WriteLine($"Idade do Cliente {this.idade}");
            Console.WriteLine($"Cpf do Cliente {this.cpf}");
            Console.WriteLine($"Sexo do Cliente {this.sexo}");
        }

    }
}

    

