using ExercicioContribuintesPolimorfismo.Entities;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");
        int quantidadeContribuintes = int.Parse(Console.ReadLine());

        List<Pessoa> pessoas = new List<Pessoa>();
        Pessoa pessoa;

        for (int i = 0; i < quantidadeContribuintes; i++)
        {
            Console.WriteLine($"Tax payer #{i + 1} data:");
            Console.Write("Individual or company (i/c)? ");
            string choice = Console.ReadLine();

            if (choice == "i")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Health expenditures: ");
                double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pessoa = new PessoaFisica(name, ganhoAnual, gastosSaude);
                pessoas.Add(pessoa);
            }
            if (choice == "c")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Number of employees: ");
                int qtdFuncionarios = int.Parse(Console.ReadLine());

                pessoa = new PessoaJuridica(name, ganhoAnual, qtdFuncionarios);
                pessoas.Add(pessoa);
            }
        }
    }
}