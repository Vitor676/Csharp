namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            
            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

           
            pilha.Pop();

            
            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            
            Console.WriteLine("Quem é o último elemento da pilha? " + pilha.Peek());

         
            Console.WriteLine("O Gaspar faz parte da pilha? " + pilha.Contains("Gaspar"));

            
            Console.WriteLine("Numero de pessoas estão na pilha: " + pilha.Count);
        }
    }
}