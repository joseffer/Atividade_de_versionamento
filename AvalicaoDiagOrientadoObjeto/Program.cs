using System;

namespace AvalicaoDiagOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente(1,5000);
            ContaPoupanca contaPoupanca = new ContaPoupanca(1,5000,3000);

            contaCorrente.ImprimirInfConta();
            contaCorrente.EmprestimoDisponivel(); 
            contaPoupanca.ImprimirInfConta();
            contaPoupanca.CaucularRendimentos(10);
        }
    }
}
