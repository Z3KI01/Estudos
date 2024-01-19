using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {
        public static void Executar() {
            //for (int i = 1; i <= 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}.");
            //}

            //O for é uma estrutura de controle de fluxo que é utilizada para repetir um bloco de código um número específico de vezes.

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ",i);
                entrada = Console.ReadLine() ;
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            Double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);
        }
    }
}
