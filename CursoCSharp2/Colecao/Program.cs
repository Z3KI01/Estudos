using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao {
    internal class Program {
        static void Main(string[] args) {
            #region Array / vetores
            //int[] numeros = new int[5];

            
            //Array são estruturas de tipo definido que guardam mais que um valor, diferente de uma variável.
            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //numeros[2] = 55;

            //string[] nomes = { "Ezequiel", "Ana", "Narci" };
            //nomes[0] = "Logan";
            #endregion

            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            string[,] nomes = 
            {
                {"Ezequiel", "Ana", "Alex" },
                {"Alexandre", "Roger", "Bia" }
            };

            Console.WriteLine(nomes[0,1]);

            Console.Write("[" + numeros[0,0] + "]");
            Console.Write("[" + numeros[0,1] + "]");
            Console.Write("[" + numeros[0,2] + "]");
            Console.WriteLine();
            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");
            
            Console.ReadKey();
        }
    }
}
