using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes.TipoTransportes
{
    public class ClasseTransporte
    {
        private int capacidade;

        public ClasseTransporte(int capacidade)
        {
            this.capacidade = capacidade;
        }
        public int GetCapacidade()
        {
            return capacidade;
        }

        public void SetCapacidade(int capacidade)
        {
            this.capacidade = capacidade;
        }

        public virtual void Visualizar()
        {

            Console.WriteLine("\n\n************************************************************");
            Console.WriteLine("Dados do Meio de Transporte:");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Capacidade (número de passageiros: " + this.capacidade);

        }
    }
}

