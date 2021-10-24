using System;
using System.Collections.Generic;
using System.Text;

namespace AvalicaoDiagOrientadoObjeto
{
    class ContaPoupanca : ContaCorrente
    {
        double valorPoupanca { get; set; }
        double redimento { get; set; }

        public ContaPoupanca() { 
        }
        public ContaPoupanca(double idconta, double valorEmContaCorrente , double valorPoupanca):
                            base(idconta,valorEmContaCorrente)
        {
            this.valorPoupanca = valorPoupanca;
            redimento = valorPoupanca * 0.001;
     
        }
        public void ImprimirInfConta()
        {

            Console.WriteLine("O ID da sua conta é : {0} Valor da sua conta é de : {1} e o valor da sua conta corrente {2} "
                , idConta, valorEmContaCorrente,valorPoupanca);
        }
        public void CaucularRendimentos(int dias) {

            Console.WriteLine("Com o valor investido em {0} dias, seu redimento sera de : {1} centavos",dias,(redimento * dias));
        
        }

    }
}
