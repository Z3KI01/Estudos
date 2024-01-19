using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstrutraIF {
        public static void Executar() {


            /*if (exp = verdadeiro ou falso) Uma unica sentença ou um bloco de sentença 
                Sentenca;
                Sentenca */
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);
            //Acima o TryParse fica responsável pela conversão da string em um numero decimal (string para double)
            //out doble nota é a atribuição da conversão a variável nota
            
            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //Se a entrada for S ou s o bom comportamento será verdadeiro
            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s"; 
            //ToLower converte a letra maiscula para minuscula 
            bomComportamento = entrada.ToLower() == "s";


            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
                //cuidado com o ";" pois é uma sentença de código
                //estrutura de controle não tem ; 
            }
        }
    }
}
