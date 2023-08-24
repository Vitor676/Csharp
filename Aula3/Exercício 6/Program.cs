namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? Nome;
            int Codigo;
            float Salario, Reajuste;

            Console.WriteLine("Digite o Código do cargo");
            Console.WriteLine("[1] Gerente, 10%");
            Console.WriteLine("[2] Vendedor, 7%");
            Console.WriteLine("[3] Suppervisor, 9%");
            Console.WriteLine("[4] Motorista, 6%");
            Console.WriteLine("[5] Estoquista, 5%");
            Console.WriteLine("[6] Técnico de TI, 8%");
            Codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Olá qual é o seu nome ?");
            Nome = Console.ReadLine();

            Console.WriteLine("E qual é o seu salario ?");
            Salario = Convert.ToSingle(Console.ReadLine());

            switch (Codigo)
            {
                case 1:
                    Reajuste = (Salario * 10) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Gerente");
                    Console.WriteLine($"{Reajuste}");
                    break;

                case 2:
                    Reajuste = (Salario * 7) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Vendedor");
                    Console.WriteLine($"{Reajuste}");
                    break;

                 case 3:
                    Reajuste = (Salario * 9) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Supervisor");
                    Console.WriteLine($"{Reajuste}");
                    break;

                case 4:
                    Reajuste = (Salario * 6) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Motorista");
                    Console.WriteLine($"{Reajuste}");
                    break;

                case 5:
                    Reajuste = (Salario * 5) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Estoquista");
                    Console.WriteLine($"{Reajuste}");
                    break;

                case 6:
                    Reajuste = (Salario * 8) / 100;
                    Reajuste += Salario;
                    Console.WriteLine($"{Nome}");
                    Console.WriteLine("Tecnico de TI");
                    Console.WriteLine($"{Reajuste}");
                    break;


            }


        }
    }
}