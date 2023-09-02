using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosObjetos1.Classe
{
    public class PessoaJuridica : Cliente
    {
        private string cnpj;
        private string empresa;

        public PessoaJuridica(string nome, float altura, int idade, string cordoCabelo, string sexo, string cnpj, string empresa) 
            : base(nome, altura, idade, cordoCabelo, sexo)
        {
            this.cnpj = cnpj;
            this.empresa = empresa;
        }
        public string GetCnpj()
        {
            return cnpj;
        }

        public void SetCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public string GetEmpresa()
        {
            return empresa;
        }

        public void SetanodeLancamento(string empresa)
        {
            this.empresa = empresa;
        }
        public override void Visualizar()
        {


            base.Visualizar();
            Console.WriteLine($"Cnpj {this.cnpj}");
            Console.WriteLine($"Nome da Empresa {this.empresa}");


        }
    }
}
