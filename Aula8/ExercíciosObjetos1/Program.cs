using ExercíciosObjetos1.Classe;

namespace ExercíciosObjetos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cliente c1 = new Cliente("Robertin", 1.81F, 25, "Preto", "Masculino");
            c1.Visualizar();*/
            PessoaFisica pf1 = new PessoaFisica("147.852.369-00", "01/09/1995", "Robertin", 1.81F, 25, "Preto", "Masculino");
            pf1.Visualizar();
            PessoaJuridica pj1 = new PessoaJuridica("Robertin", 1.81F, 25, "Preto", "Masculino", "21.453.867/0001","Salgadin do Robertin");
            pj1.Visualizar();

            /*Cliente c2 = new Cliente("Ana", 1.69F, 22, "Ruivo", "Feminino");
            c2.Visualizar();*/
            PessoaFisica pf2 = new PessoaFisica("369.258.147-99", "09/02/1996", "Ana", 1.69F, 22, "Ruivo", "Feminino");
            pf2.Visualizar();
            PessoaJuridica pj2 = new PessoaJuridica("Ana", 1.69F, 22, "Ruivo", "Feminino", "11.588.998/0001", "Ana Cabelos e Unhas");
            pj2.Visualizar();


            

        }
    }
}