using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao_Final_modulo_1_e_2
{
    class FuncionarioTerceiro : Funcionario
    {
        public string empresaOrigem { get; set; }
        public double taxaServico { get; set ; }


        public FuncionarioTerceiro() { 
        }
        public FuncionarioTerceiro(string nome, int cargaHoraia, int valorHora, string empresaOrigem, double taxaServico):
            base(nome,cargaHoraia,valorHora)
        {

            this.empresaOrigem = empresaOrigem;
            this.taxaServico = taxaServico;
        }

        public override double CalcularSalario()
        {
            return (((CargaHoraria * ValorHora) * this.taxaServico) + CargaHoraria * ValorHora);
        }
        public override void ImprimirDados()
        {
            Console.WriteLine("Funcionario Terceiro: {0}, sua empresa {1}, seu salario é de : R$:{2}",this.Nome , this.empresaOrigem, CalcularSalario());
        }

    }
}
