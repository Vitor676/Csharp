namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Número, Quantidade, Total;

            Console.WriteLine("1 - Cachorro Quente R$10,00");
            Console.WriteLine("2 - X- Salada R$15,00");
            Console.WriteLine("3 - X- Bacon R$18,00");
            Console.WriteLine("4 - Bauru  R$12,00");
            Console.WriteLine("5 - Refrigerante R$8,00");
            Console.WriteLine("6 - Suco de Laranja R$13,00");
            Número = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Qual a quantidade desejada ?");
            Quantidade = Convert.ToInt32(Console.ReadLine());

            switch (Número)
            {
                case 1:
                    Número = 10;
                    Total = Quantidade * Número;
                    Console.WriteLine($"Cachorro Quente, Valor total: {Total} ");
                    break;

                case 2:
                    Número = 15;
                    Total = Quantidade * Número;
                    Console.WriteLine($"X- Salada, Valor total: {Total} ");
                    break;

                case 3:
                    Número = 18;
                    Total = Quantidade * Número;
                    Console.WriteLine($"X- Bacon, Valor total: {Total} ");
                    break;

                case 4:
                    Número = 12;
                    Total = Quantidade * Número;
                    Console.WriteLine($"Bauru, Valor total: {Total} ");
                    break;

                case 5:
                    Número = 8;
                    Total = Quantidade * Número;
                    Console.WriteLine($"Refrigerante, Valor total: {Total} ");
                    break;

                case 6:
                    Número = 13;
                    Total = Quantidade * Número;
                    Console.WriteLine($" Suco de Laranja, Valor total: {Total} ");
                    break;

                default:
                    Console.WriteLine("Opção não existente!!!");
                    break;



            }





        }
    }
}