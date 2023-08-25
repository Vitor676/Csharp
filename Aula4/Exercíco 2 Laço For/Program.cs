namespace Exercíco_2_Laço_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, par = 0, impar = 0;

          

            for ( int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(" Digite os números ");
                numero = Convert.ToInt32(Console.ReadLine());
                

                if (numero % 2 == 0)
                {      
                par++;
                 }

                else

                {
                    impar++;
                }
            }

            

            
           
           

            {
                
                Console.WriteLine($"Total de Números Pares {par} ");
                Console.WriteLine($"Total de Números impares {impar} ");
                Console.ReadKey();
            }
        }
    }
}