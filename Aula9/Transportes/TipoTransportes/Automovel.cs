using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes.TipoTransportes
{
    public class Automovel : Terrestre
    {
        private string cor;
        private string placa;
        private int portas;
        private int marcha;
        public Automovel(int numeroRodas, float velocidade, int capacidade, int portas, int marcha, string cor, string placa) : base(numeroRodas, velocidade, capacidade)
        {
            this.portas = portas;
            this.cor = cor;
            this.placa = placa;
            this.marcha = marcha;
        }
        public int GetPortas()
        {
            return portas;
        }

        public void SetPortas(int portas)
        {
            this.portas = portas;
        }

        public string GetCor()
        {
            return cor;
        }

        public void SetCor(string cor)
        {
            this. cor = cor;
        }

        public int GetMarcha()
        {
            return marcha;
        }

        public void SetMarcha(int marcha)
        {
            this.marcha = marcha;
        }

        public string GetPlaca()
        {
            return placa;
        }

        public void SetPortas(string placa)
        {
            this.placa = placa;
        }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine("Número de Portas: " + this.portas);
            Console.WriteLine("Cor : "  + this.cor);
            Console.WriteLine("Placa : "  + this.placa);
            Console.WriteLine("Número de Marchas : "  + this.marcha);

        }
    }
}
