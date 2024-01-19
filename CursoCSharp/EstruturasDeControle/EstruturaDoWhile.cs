using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaDoWhile {
        public static void Executar() {
            string entrada;

            //O "do" faz com que a condição seja executada pelo menos uma vez antes do While até que a condição se torne falsa
            do {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();

                //Estrutura de repetição
                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Deseja continua (S/N)");
                entrada = Console.ReadLine();
                //ToLower trabalha com a conversão de letras maisculas para minusculas e vice e versa
            } while (entrada.ToLower() == "s");
        }
    }
}
