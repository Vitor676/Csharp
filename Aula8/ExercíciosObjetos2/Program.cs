using ExercíciosObjetos2.Loja_Games;
using System.Net.Http.Headers;

namespace ExercíciosObjetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Produto p1 = new Produto("God Of War", 300.00M, "10/10", "Jogo de Consoles e Pc", "Studio Santa Monica"  );
            p1.Visualizar();*/
            Games g1 = new Games("Maior de 18 Anos", "Um Classico dos Jogos", "God Of War", 300.00M, "10/10", "Jogo de Consoles e Pc", "Studio Santa Monica");
            g1.Visualizar();
            VideoGame vd1 = new VideoGame("Playstation", 5000.00M, "10/10", "Console de Ultima Geração", "Sony", "Console de Mesa e Portatil", "2021");
            vd1.Visualizar();

            /*Produto p2 = new Produto("Gta S.a", 250.00M, "9/10", "Jogo de Consoles e Pc", "Rockstar");
            p2.Visualizar();*/
            Games g2 = new Games("Maior de 18 Anos", "O Melhor Jogo de Mundo Aberto", "Gta S.a", 250.00M, "9/10", "Jogo de Consoles e Pc", "Rockstar");
            g2.Visualizar();
            VideoGame vd2 = new VideoGame("Xbox", 5000.00M, "10/10", "Console de Ultima Geração", "Microsoft", "Console de Mesa e Portatil", "2021");
            vd2.Visualizar();
        }
    }
}