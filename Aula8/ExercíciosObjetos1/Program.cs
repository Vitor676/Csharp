using ExercíciosObjetos1.Classe;

namespace ExercíciosObjetos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Robertin", 1.81F, 25, "54678914708", "Masculino");
            c1.Visualizar();

            c1.SetNome("Robertin");
            c1.SetAltura(1.81F);
            c1.SetIdade(25);
            c1.SetCpf("54678914708");
            c1.SetNome("Masculino");

            Cliente c2 = new Cliente("Anaconda", 1.69F, 22, "75395125869", "Feminino");
            c2.Visualizar();

            c1.SetNome("Anaconda");
            c1.SetAltura(1.69F);
            c1.SetIdade(22);
            c1.SetCpf("75395125869");
            c1.SetNome("Feminino");
        }
    }
}