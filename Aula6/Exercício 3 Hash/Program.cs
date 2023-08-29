namespace Exercício_3_Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();

            for (int indice = 0; indice < 10; indice++)

            {
                Console.WriteLine("Digite seu Número");
                int valor = Convert.ToInt32(Console.ReadLine());
                numeros.Add(valor);

            }
            Console.WriteLine("\n lista de números:");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}