namespace ExercicioContribuintesPolimorfismo.Entities
{
    internal abstract class Pessoa
    {
        private string _nome;
        private double _rendaAnual;

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length > 2 && value != null
                    && string.IsNullOrWhiteSpace(value) == false)
                {
                    _nome = value;
                }
            }
        }
        public double RendaAnual
        {
            get
            {
                return _rendaAnual;
            }
            set
            {
                if (value > 0.0)
                {
                    _rendaAnual = value;
                }
            }
        }
        public abstract double Imposto();
    }
}
