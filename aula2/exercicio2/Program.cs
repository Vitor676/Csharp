namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, média;

            Console.WriteLine("Digite a sua primeira nota");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a sua segunda nota");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a sua terceira nota");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a sua quarta nota");
            n4 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            média = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"Sua média é:{média:F1}");
        }
    }
}