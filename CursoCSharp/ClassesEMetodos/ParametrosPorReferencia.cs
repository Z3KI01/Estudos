using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosPorReferencia {

        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }


        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");

            //ref: Você passa a variável para o método, e o método pode modificá-la diretamente. O valor inicia da variável é importante.

            //out: Você passa a variável para o metodo para ser inicializada dentro do método. A variável não precisa ter um valor inicial antes de ser passada.
        }
    }
}
