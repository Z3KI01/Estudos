using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class Exercicio {
        public static void Executar() {
            Console.WriteLine("Digite o primeiro numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            //Converte a string para double 


            Console.WriteLine("Escolha a primeira opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            Console.Write("Digite o numero da operação desejada:");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Converte para numero inteiro de 32 bits

            double resultado = 0;

            switch (escolha) {
                case 1:
                    resultado = numero1 + numero2; break;
                case 2:
                    resultado = numero1 - numero2; break;
                case 3:
                    resultado = numero1 * numero2; break;
                case 4:
                    if (numero2 != 0) // != Não igual
                        resultado = numero1 / numero2;
                    else
                        Console.WriteLine("Não é possivel dividir por zero");
                    break;
                default: Console.WriteLine("Escolha invalida"); break;

            }
            Console.WriteLine("Resultado: " + resultado);

            Console.ReadKey();
        }
    }
}
