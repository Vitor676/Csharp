namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Número1, Número2, Número3, Soma;

            Console.WriteLine("Digite o primeiro Número:");
            Número1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número:");
            Número2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro Número:");
            Número3 = Convert.ToInt32(Console.ReadLine());

            Soma = Número1 + Número2;

            if (Soma > Número3)
            {
                Console.WriteLine($"A soma de {Número1} e {Número2}, é maior que {Número3} ");

            }
            else if (Soma < Número3)
            {
                Console.WriteLine($"A soma de {Número1} e {Número2}, é menor que {Número3} ");

            }

            else if (Soma == Número3)
            {

                Console.WriteLine($"A soma de {Número1} e {Número2}, é igual á {Número3} ");
            }

        }
    }
}