using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        //Os operadores relacionais (como >, <, ==, !=, >= e <=) comparam dois valores e retornam um resultado booleano, ou seja, verdadeiro (true) se a condição for atendida e falso (false) caso contrário.
        public static void Executar() {
            //double nota = 6.0;
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            //Maior que 
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            //Menor que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            //Igual
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            //Diferente
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            //Maior ou igual
            Console.WriteLine("Pasou por média? {0}", nota >= notaDeCorte);
            //Menor que 
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            //Menor ou igual
            Console.WriteLine("Reprovado? {0}", nota <= 3,0);

        }
    }
}