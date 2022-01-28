using PagamentoFuncionario.Entidades;
using System;
using System.Collections.Generic;

namespace PagamentoFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Digite a quantidade de funcionario: ");
            int qtdeFuncionario = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdeFuncionario; i++)
            {
                Console.WriteLine("O funcionario é tercerizado?(y/n) ");
                string funcionarioTerceirzado = Console.ReadLine();

                if(funcionarioTerceirzado == "y")
                {
                    Console.WriteLine("Digite o nome do funcionario: ");
                    string nomeFuncionario = Console.ReadLine();

                    Console.WriteLine("Hora de trabalho: ");
                    int horaTrabalho = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor recebido por hora: ");
                    double valorFuncionario = double.Parse(Console.ReadLine());

                    Console.WriteLine("Valor da taxa adicional: ");
                    double taxaAdicional = double.Parse(Console.ReadLine());

                    Funcionario funcTercerizado = new FuncionarioTerceirzado(nomeFuncionario, horaTrabalho, valorFuncionario, taxaAdicional);

                    funcTercerizado.pagamento();
                    funcionarios.Add(funcTercerizado);
                } else {
                    Console.WriteLine("Digite o nome do funcionario: ");
                    string nomeFuncionario = Console.ReadLine();

                    Console.WriteLine("Hora de trabalho: ");
                    int horaTrabalho = int.Parse(Console.ReadLine());

                    Console.WriteLine("Valor recebido por hora: ");
                    double valorFuncionario = double.Parse(Console.ReadLine());

                    Funcionario funcCLT = new Funcionario(nomeFuncionario, horaTrabalho, valorFuncionario);
                    funcionarios.Add(funcCLT);
                }
            }
            Console.WriteLine("Pagamentos: ");
            foreach(Funcionario func in funcionarios)
            {
                Console.WriteLine(func); 
            }
        }

        
    }
}
