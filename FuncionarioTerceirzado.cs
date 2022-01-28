namespace PagamentoFuncionario.Entidades
{
    internal class FuncionarioTerceirzado : Funcionario
    {
        public double taxaAdicional;

        public FuncionarioTerceirzado()
        {
        }

        public FuncionarioTerceirzado(string nome, int hora, double valorPorHora, double taxaAdicional) : base(nome, hora, valorPorHora)
        {
            this.taxaAdicional = taxaAdicional;
        }

        public sealed override double pagamento()
        {
            return base.pagamento() + taxaAdicional * 1.1;
        }
    }
}
