using System.Globalization;
using System.Text;

namespace ExercicioContribuintesPolimorfismo.Entities
{
    internal class PessoaFisica : Pessoa
    {
        private double _gastosSaude;

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            _gastosSaude = gastosSaude;
        }
        public double GastosSaude
        {
            get
            {
                return _gastosSaude;
            }
            set
            {
                if (value > 0.0)
                {
                    _gastosSaude = value;
                }
            }
        }
        public override double Imposto()
        {
            if (RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15) - (GastosSaude * 0.50);
            }
            return (RendaAnual * 0.25) - (GastosSaude * 0.50);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome + ": $ " + Imposto().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
