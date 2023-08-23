namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Salario, abono, novoSalario;

            Console.WriteLine("Digite o salario");
            Salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o abono");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = Salario + abono;
            Console.WriteLine($"Seu novo salario é:{novoSalario:F}");
        }
    }
}