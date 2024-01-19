using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {

        //Método de Classe ou Método estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de objeto
        public int Somar (int a, int b) {
            return a + b;
        }

        public int Divisao(int a, int b) {
            if (b != 0) {
                return a / b;
            } else {
                Console.WriteLine("Não é possível dividir por zero");
                return 0;
            }
        }
    }

    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado: {0} ",calc.Somar(2, 2));

            CalculadoraEstatica calc2 = new CalculadoraEstatica();
            Console.WriteLine("Resultado: {0}",calc2.Divisao(8, 2));
        }
    }
}
