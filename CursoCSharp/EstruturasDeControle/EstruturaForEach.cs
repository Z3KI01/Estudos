using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var palavra = "Eu te Amo Ana Clara De Oliveira!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            //For each percore do primeiro até o ultimo elemento sem necessidade de criar algo muito complexo.
            var alunos = new string[] { "Ana", "Ezequiel", "Carlos" };
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
