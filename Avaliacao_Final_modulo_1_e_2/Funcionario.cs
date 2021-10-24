using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliacao_Final_modulo_1_e_2
{
    class Funcionario
    {
        string nome;
        public int CargaHoraria { get; set; }
        public int ValorHora { get; set; }
        
        
        public string Nome {

            get { return nome; }
            set {

                if (value.Length < 3)
                    Console.WriteLine("Nome Invalido");
                
                else 
                    nome = value;
            }
        }
        public Funcionario() { }
        public Funcionario(string nome , int cargaHorararia, int valorHora) {
            this.nome = nome;
            this.CargaHoraria = cargaHorararia;
            this.ValorHora = valorHora;
        }

        public virtual double CalcularSalario() {
            return (CargaHoraria * ValorHora);
        }
        public virtual void ImprimirDados() {

            Console.WriteLine("Funcionario {0}, seu salario é de : R${1}",this.nome,CalcularSalario());
        }
    }
}
