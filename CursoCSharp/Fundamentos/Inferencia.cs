using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Ana Clara";
            Console.WriteLine(nome);
            // nome = 123; 
            //O C# detectou a variavel automaticamente somente por inserir "Ana Clara" posteriormente a nome

            //int idade;
            //Ao usar a inferencia, não podemos declarar a variavel e atrivuir um valor na linha posterior
            var idade = 32;
            Console.WriteLine(idade);

            //exemplo de declaração de variavel e atribuição posterior
            int a;
            a = 3;
            
            //Exemplo de declaração de variável e atribuição na mesma linha
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
