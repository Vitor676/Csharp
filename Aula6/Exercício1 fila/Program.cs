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
                Console.WriteLine("***************************************************");
                Console.WriteLine("");
                Console.WriteLine("\t1 - Adicionar Cliente a fila");
                Console.WriteLine("\t2 - Listar Todos os Clientes");
                Console.WriteLine("\t3 - Retirar Cliente da fila");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine("");
                Console.WriteLine("***************************************************");

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Insira o nome do cliente: ");
                        string? nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        break;
                    case 2:
                        Console.WriteLine("Lista de clientes na fila: ");
                        Console.WriteLine(fila);
                        break;
                    case 3:
                        if (fila.Count > 0)
                        {
                            Console.WriteLine("Insira o nome do cliente a ser retirado: ");
                            string nomeRetirado = Console.ReadLine();
                            fila.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
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