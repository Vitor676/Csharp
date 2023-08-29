namespace Exercício_1_Collections_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();

            while (cores.Count < 5)
            { 
            Console.WriteLine("Insira a sua cor");
                string cor = Console.ReadLine();
                cores.Add(cor);
            }

            foreach (var lista in cores)
            { 
            Console.WriteLine(lista);
            }
            
            Console.WriteLine();
            cores.Sort();

            foreach (var lista in cores)
            {
                Console.WriteLine(lista);
                
            }
        }
    }
}