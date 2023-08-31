using ExercíciosObjetos2.Loja_Games;

namespace ExercíciosObjetos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Games g1 = new Games("God Of War", "Maior de 18 anos", 200, 10/10, "Um dos Melhores jogos da História");
            g1.Visualizar();

            g1.SetNome("God of War");
            g1.Setclassificação("Maior de 18 anos");
            g1.Setpreço(200);
            g1.Setnota(10);
            g1.Setcomentario("Um dos Melhores jogos da História");

            Games g2 = new Games("Gta S.A", "Maior de 18 anos", 200, 10 / 10, "Melhor Jogo de Mundo Aberto");
            g2.Visualizar();

            g2.SetNome("Gta S.A");
            g2.Setclassificação("Maior de 18 anos");
            g2.Setpreço(200);
            g2.Setnota(10/10);
            g2.Setcomentario("Melhor Jogo de Mundo Aberto");

        }
    }
}