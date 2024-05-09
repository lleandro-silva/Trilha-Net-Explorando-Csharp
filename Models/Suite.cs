namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        private string tipoSuite;
        private int capacidade;
        private decimal valorDiaria;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            if (string.IsNullOrEmpty(tipoSuite))
            {
                throw new ArgumentException("O tipo da suíte não pode ser nulo ou vazio.");
            }

            if (capacidade <= 0)
            {
                throw new ArgumentException("A capacidade da suíte deve ser maior que zero.");
            }

            if (valorDiaria <= 0)
            {
                throw new ArgumentException("O valor da diária da suíte deve ser maior que zero.");
            }

            this.tipoSuite = tipoSuite;
            this.capacidade = capacidade;
            this.valorDiaria = valorDiaria;
        }

        public string TipoSuite => tipoSuite;
        public int Capacidade => capacidade;
        public decimal ValorDiaria => valorDiaria;
    }
}