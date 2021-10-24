using System;

namespace Avaliacao_Final_modulo_1_e_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Pietro",10,200);
            Funcionario funcionarioTerceiro = new FuncionarioTerceiro("joseffer", 10, 20, "itau", 0.10);

            do {
                Console.WriteLine("Digite N para ver informações de funcionario  ou T para funcionario Terceiro");
                switch (Console.ReadLine()) {
                    case "n": funcionario.ImprimirDados(); break;
                    case "N": funcionario.ImprimirDados(); break;
                    case "t": funcionarioTerceiro.ImprimirDados(); break;
                    case "T": funcionarioTerceiro.ImprimirDados(); break;
                    default: Console.WriteLine("Caracter invalido"); break;
                }
                Console.WriteLine("Digite 1 para continuar ou outra tecla para sair");
            } while (Int32.Parse(Console.ReadLine()) == 1);
        }
    }
}
