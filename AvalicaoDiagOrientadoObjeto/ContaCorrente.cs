using System;
using System.Collections.Generic;
using System.Text;

namespace AvalicaoDiagOrientadoObjeto
{
    class ContaCorrente
    {

        public double idConta { get; set; }
        public double valorEmContaCorrente { get; set; }

         public ContaCorrente()
        {
        }
        public ContaCorrente(double idconta, double valorEmContaCorrente)
        {
            this.idConta = idConta;
            this.valorEmContaCorrente = valorEmContaCorrente;
        }

        public  virtual void ImprimirInfConta()
        {

            Console.WriteLine("O ID da sua conta é : {0} Valor da sua conta é de : {1} ", idConta, valorEmContaCorrente);
        }
        public double ValorEmprestimo()
        {
            return (valorEmContaCorrente * 0.5);
        }
        public void EmprestimoDisponivel()
        {

            Console.WriteLine("o valor disponivel para seu emprestimo é de {0}", ValorEmprestimo());
        }

    }
}
