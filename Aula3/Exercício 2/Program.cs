namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Número;
            string Parimp, Negpsot;

            Console.WriteLine("Digite o seu Numero");
            Número = Convert.ToSingle(Console.ReadLine());

            if (Número % 2 == 0)
            {
                Parimp= "par";
            }
            else 
            {
                Parimp = "impar";
            }
            if (Número >= 0)
            {
                Negpsot = "positivo";

            }
            else 
            {
                Negpsot = "negativo";
            }
            Console.WriteLine($"O Número {Número} é {Parimp} e {Negpsot}");
            Console.ReadKey();


        }
    }
}