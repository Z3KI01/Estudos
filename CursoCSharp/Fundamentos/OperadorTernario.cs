using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        //Operador ternario ?:
        //nota >= 7.0 && bomComportamento é a condição, "Aprovado" é a expressãoSeVerdadeira, "Reprovado" é a expressãoSeFalsa.


        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
