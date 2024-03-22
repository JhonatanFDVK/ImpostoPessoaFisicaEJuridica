using ExercicioContribuintesPolimorfismo.Entities;

class Program
{
    static void Main(string[] args)
    {
        PessoaJuridica p1 = new PessoaJuridica("Jhonatan", 400000.00, 25);

        Console.WriteLine(p1.Imposto());
    }
}