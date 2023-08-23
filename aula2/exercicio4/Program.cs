namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, diferença;

            Console.WriteLine("Digite seu priemiro numero");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite seu segundo numero");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite seu terceiro numero");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite seu quarto numero");
            n4 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            diferença = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"A diferença é:{diferença:F1}");
        }
    }
}