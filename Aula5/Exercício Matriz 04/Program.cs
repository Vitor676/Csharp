namespace Exercício_Matriz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz01 = new int[3, 3];
            int somaprincipal = 0 , somasecundaria = 0 ;



            for (int indicelinha = 0; indicelinha < matriz01.GetLength(0); indicelinha++)

                for (int indicecoluna = 0; indicecoluna < matriz01.GetLength(1); indicecoluna++)
                {
                    Console.WriteLine($"Informe seus Números: {indicelinha} , {indicecoluna} ");
                    matriz01[indicelinha, indicecoluna] = Convert.ToInt32(Console.ReadLine());

                }
            for (int indicelinha = 0; indicelinha < matriz01.GetLength(0); indicelinha++)

                for (int indicecoluna = 0; indicecoluna < matriz01.GetLength(1); indicecoluna++)
                {
                    if (indicelinha == indicecoluna)
                    {
                       Console.WriteLine($"A diagonal principal é: {matriz01 [indicelinha , indicecoluna]}");
                        somaprincipal += matriz01[indicelinha, indicecoluna];
                    }
                    

                }
                    

            for (int indicelinha = 0; indicelinha < matriz01.GetLength(0); indicelinha++)

                for (int indicecoluna = 0; indicecoluna < matriz01.GetLength(1); indicecoluna++)
                {
                    if ((indicelinha + indicecoluna) == matriz01.GetLength(0) - 1)

                    {
                       Console.WriteLine($"A diagonal secundaria é: {matriz01[indicelinha, indicecoluna]}");
                        somasecundaria += matriz01[indicelinha, indicecoluna];
                    }
                    
                   

                }
            Console.WriteLine($"O resultado da soma principal é {somaprincipal} :");
            Console.WriteLine($"O resultado da soma secundaria é {somasecundaria} :");

        }

    }
}