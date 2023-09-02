using Transportes.TipoTransportes;

namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terrestre t1 = new Terrestre(4, 80.0F,4);
            t1.Visualizar();
            Automovel a1 = new Automovel(4, 80.0F, 4, 4, 6, "Preto", "KLK 0001");
            a1.SetCor("Branco");
            a1.Visualizar();
        }
    }
}