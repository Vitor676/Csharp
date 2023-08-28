namespace Exercício_Vetores_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor =  { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int compara = 0;

            for (int i = 0; i < vetor.Length; i ++)
            {
                Console.Write($"{vetor[i]}" + " ");
            }

            Console.WriteLine("\nDigite seu Número para ver sua posição ");
            compara = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(vetor, compara) != -1 )
            { 
            Console.WriteLine($"A posição de {compara} é:" + Array.IndexOf(vetor, compara));
            }

            else 
            { 
            Console.WriteLine($" Não temos esse numero ");
            }

            
            
           
               
           
            
        }
    }
}