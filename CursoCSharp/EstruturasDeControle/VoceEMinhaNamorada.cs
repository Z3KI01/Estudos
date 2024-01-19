using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class VoceEMinhaNamorada {
        public static void Executar() {

            do {
                Console.WriteLine("Estou procurando minha namorada, é você?");
                Console.WriteLine("Qual seu nome:");
                string pessoa = Console.ReadLine();

                if (pessoa == "Ana Clara de Oliveira") {
                    Console.WriteLine($"Oi {pessoa}, sabia que você é o Amor da minha vida!");
                    break;
                }
                else {
                    Console.WriteLine("Deseja tentar novamente: (S/N)");
                }
            } while (Console.ReadLine().ToUpper() == "S");
        }
    }
}
