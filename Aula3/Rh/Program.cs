namespace Rh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            

            Console.WriteLine("Qual o seu cargo ?");
            Console.WriteLine("1 - Supervisor");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("4 - Outros");
            cargo = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Informe seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());
            

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    reajuste += salario;
                    Console.WriteLine($"O valor do reajuste de é: {reajuste:c}");
                    break; 

            
            
        }
    }
}