namespace Rh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste;

            Console.WriteLine(" Digite seu cargo");

            Console.WriteLine("1 - Supervisror ");
            Console.WriteLine("2 - Diretor ");
            Console.WriteLine("3 - Gerente ");
            Console.WriteLine("4 - Outros ");

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {

                case 1:
                    reajuste = (salario * 7) / 100; 
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
               default:
                    reajuste = (salario * 12) / 100;
                    break;
                


            }

            Console.WriteLine($" O reajuste do(a) {nome} {reajuste} é de ");
            Console.WriteLine($" O novo salário do(a) {salario + reajuste} é de :");

        }
    }
}