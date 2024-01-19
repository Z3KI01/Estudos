using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores {
    internal class Program {
        static void Main(string[] args) {

            #region Operadores matemáticos.
            //int num1 = 10;
            //int num2 = 2;
            //int resultado = 10 + 2;
            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            #endregion

            #region Procedência de Operadores.
            //Ordem de prioridade: 
            //1 > () Operações entre paresentes;
            //2 > * / Multiplicação de divisão;
            //3 > + - Adicção ou subtração;


            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double res = (num1 + num2) * (num3 / 3);
            #endregion

            #region Incremento e decremento.
            //int num1 = 10;

            //um1++;//num1= num1 + 1;
            //Pré incremento = Primeiro o valor é acrescido, posterior os próximos processos são feitos
            //Pós incremento = Ao contrário;
            //num1++;
            //++num1;
            //num1--;
            //--num1;
            #endregion

            #region Concatenação.
            //string nome = "Ezequiel ";
            //string sobreNome = "Walginski";
            //string nomeCompleto = nome + sobreNome + " " +  2005;
            #endregion

            #region Operadores de atribuição
            //int num1 = 10; // = Operador de atribuição

            //num1 = num1 + 20;

            //num1 += 20; //Recebe o prórpio valor + 20
            //num1 += 20; //Recebe o prórpio valor + 20
            //num1 -= 2; //Recebe o prórpio valor - 2
            //num1 *= 3; //Recebe o prórpio valor * 3
            //num1 /= 2; //Recebe o prórpio valor / 2
            //num1 %= 2; //Resto da divisão dele mesmo por 2

            //string nome = "Ezequiel";
            //nome += " Walginski";
            #endregion

            #region Comparação / Igualdade.
            ////Operadores de igualdade retornam true ou false a depender do resultado
            //bool res = 100 == ( 50 * 2); // == Igual que
            //bool res2 = 200 != 100 + 100; //!= diferente que 

            //string nome = "Ezequiel";
            //bool res3 = nome != "Ana";
            #endregion

            #region Operadores Relacionais
            // > Maior que 
            // < Menor que 
            // <= Menor igual que
            // >= Maior igual que 
            //bool res = 100 < 50 * 2;
            //bool res = 100 + 25 > 50 * 2;
            //bool res = 100 <= 50 * 2;
            //bool res = 75 >= 50 * 2;
            #endregion

            #region Operadores lógicos
            //&& As duas expressões precisam ser verdadeiras
            //|| Pelo menos uma das expressões precisa ser verdadeira
            bool res1 = 100 == 50;
            bool res2 = 60 == 50;

            bool final = res1 && res2;
            bool final2 = res1 || res2;
            #endregion 

            Console.WriteLine(final2);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
