using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos1.Classe
{
    public class PessoaFisica : Cliente
    {
        private string cpf;
        private string datadeaniversario;
        public PessoaFisica(string cpf, string datadeaniversario, string nome, float altura, int idade, string cordoCabelo, string sexo) 
            : base(nome, altura, idade, cordoCabelo, sexo)
        {
            this.cpf = cpf;
            this.datadeaniversario = datadeaniversario;
        }
        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetdatadeAniversario()
        {
            return datadeaniversario;
        }

        public void SetAltura(string datadeaniversario)
        {
            this.datadeaniversario = datadeaniversario;
        }
        public override void Visualizar()
        {


            base.Visualizar();
            Console.WriteLine($"Cpf do Cliente {this.cpf}");
            Console.WriteLine($"Data de Aniversario do Cliente {this.datadeaniversario}");

        }

    }
}
