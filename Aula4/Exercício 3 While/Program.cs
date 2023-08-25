namespace Exercício_3_Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idades = 1, menor21 = 0, maior50 = 0;

            while (idades > - 1)
            {
              Console.WriteLine("Coloque a sua idade");
                idades = Convert.ToInt32(Console.ReadLine());
                

               

                if (idades <= 21 && idades > 0 )
                    menor21++;

                if (idades >= 50)
                    maior50++;


            }
            Console.WriteLine($"Pessoas menores de 21 anos : {menor21}");
            Console.WriteLine($"Pessoas maiores de 50 anos : {maior50}");
            Console.ReadKey();
        }
    }
}