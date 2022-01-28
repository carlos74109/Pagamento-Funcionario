namespace PagamentoFuncionario.Entidades
{
    internal class Funcionario
    {

        public string nome { get; set; }
        public int hora;
        public double ValorPorHora;
        public Funcionario()
        {
        }

        public Funcionario(string nome, int hora, double valorPorHora)
        {
            this.nome = nome;
            this.hora = hora;
            ValorPorHora = valorPorHora;
        }

        public virtual double pagamento()
        {
            return hora * ValorPorHora;
        }

        public override string ToString()
        {
            return nome + " - " + " R$" + pagamento();
                     
        }
    }
}
