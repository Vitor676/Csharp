namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Saláriobruto, Adicionalnoturno, Horasextras, Descontos, Saláriolíquido;

            Console.WriteLine("Digite seu Salário bruto");
            Saláriobruto = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite seu Adicional Noturno");
            Adicionalnoturno = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite suas Horas Extras");
            Horasextras = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite seus Descontos");
            Descontos = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Saláriolíquido = Saláriobruto + Adicionalnoturno + (Horasextras * 5) - Descontos;
            Console.WriteLine($"Seu Salário Liquido é:{Saláriolíquido:F}");
        }
    }
}