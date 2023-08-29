namespace Exercicío_01_Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Queue<string> fila = new Queue<string>();

            do
            {
                Console.WriteLine("***************");
                Console.WriteLine();
                Console.WriteLine("\t1 - Adicionar cliente na fila");
                Console.WriteLine("\t2 - Listar todos os clientes");
                Console.WriteLine("\t3 - Retirar clientes da fila");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine();
                Console.WriteLine("***************");
                Console.WriteLine("\tInsira a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Insira o nome do cliente: ");
                        string? nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        break;

                    case 2:
                        Console.WriteLine("Lista de clientes na fila: ");
                        foreach (var clientes in fila)
                        {
                            Console.WriteLine(clientes);
                        }
                        break;

                    case 3:
                        if (fila.Count > 0)
                        {
                            fila.Dequeue();
                            foreach (var clientes in fila)
                            {
                                Console.WriteLine(clientes);
                            }
                            Console.WriteLine($"O cliente foi chamado!");
                        }

                        else
                        {
                            Console.WriteLine("A fila está vazia!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("finalizando!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}