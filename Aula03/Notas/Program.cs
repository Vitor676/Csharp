using System.Net.Http.Headers;

namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, média;

            Console.Write("Digite a priemira nota");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a segunda nota");
            nota2 = Convert.ToSingle(Console.ReadLine());

            média = (nota1 + nota2) / 2;

            Console.WriteLine((média >= 6) ? "Aprovado!" : "Reprovado!");

            // condição ? ação verdade : ação para falso
        }
    }
}