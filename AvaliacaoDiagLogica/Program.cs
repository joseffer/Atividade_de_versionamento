using System;

namespace AvaliacaoDiagLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 10;
            int valorProcurado = 0;
            int[] numero = new int[tamanho];
            int contador = 0;

          do {
                for (contador = 0; contador < tamanho; contador++) {
                    Console.WriteLine(" digite o valor da posicao {0}",contador+1);
                    numero[contador] = Int32.Parse(Console.ReadLine()); 
                }
                Console.WriteLine(" digite o valor procurado");
                valorProcurado = Int32.Parse(Console.ReadLine());

                for (contador = 0; contador < tamanho; contador++)
                {
                    if (valorProcurado == numero[contador]) {
                        if ((valorProcurado % 2) == 0)
                             Console.WriteLine("O numero :{0} é Par e foi encontrado com sucesso!",valorProcurado);
                        else
                             Console.WriteLine("O numero :{0} é Impar e foi encontrado com sucesso!", valorProcurado);
                        break;        
                    }
                }
                if(tamanho == contador)
                {
                    Console.WriteLine("o numero {0} não foi encontrado",valorProcurado);
                }
                    Console.WriteLine("Digite 1 para continuar ou qualquer outro numero para sair");
            } while (Int32.Parse(Console.ReadLine()) == 1);
        }
    }
}
