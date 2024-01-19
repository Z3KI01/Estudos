using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valoreNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boleano = true;

            // O - vai reverter o valor do numero, se estiver com -, será convertido para +
            Console.WriteLine(-valoreNegativo);
            
            //! Imprime na tela o valor contrário do bool, se for verdadeiro, será convertido para falso
            Console.WriteLine(!boleano);

            // numero 1 = numero1 + 1 
            numero1++; // ex de pósfixado
            Console.WriteLine(numero1);

            // numero 1 = numero1 - 1
            --numero1;//Exemplo de préfixado
            Console.WriteLine(numero1);

            //Préfixado sempre vai ter maior procedencia sobre o pós fixado.
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
