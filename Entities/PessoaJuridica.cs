using System.Globalization;
using System.Text;

namespace ExercicioContribuintesPolimorfismo.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        private int _numeroFuncionarios;

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            _numeroFuncionarios = numeroFuncionarios;
        }
        public int NumeroFuncionarios
        {
            get
            {
                return _numeroFuncionarios;
            }
            set
            {
                if (value > 0)
                {
                    _numeroFuncionarios = value;
                }
            }
        }
        public override double Imposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return RendaAnual * 0.14;
            }
            return RendaAnual * 0.16;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nome + ": $ " + Imposto().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
