using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Parans {
        //Para conjuntos variáveis de Parans
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        } 
        public static void Executar() {
            Recepcionar("Narci", "Ana", "Ezequiel", "Terezinha", "Narci");
            
        }
    }
}
