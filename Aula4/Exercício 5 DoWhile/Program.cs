namespace Exercício_5_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = 1, soma = 0;

            do
            {
                Console.WriteLine("Digite o seu numero");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada > 0)
                    soma += entrada;


            } while (entrada!=0);

            Console.WriteLine($"soma numeros positivos é : {soma}");

            
        }
    }
}