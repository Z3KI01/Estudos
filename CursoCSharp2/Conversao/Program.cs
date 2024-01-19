using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao {
    internal class Program {
        static void Main(string[] args) {

            #region Conversão Implicita.
            ////Conversão implicita = Não tem perca de informações 
            //byte num1 = 100; //8bits, de 0 a 255
            //ushort num2; // 16 bits, 0 a 65.535

            //float num3 = 1250.45f;
            //double num4 = num3;

            //num3 = num1;

            //num2 = num1; //Permite conversão sem problemas.

            //int numero = 'c'; //Vai exebir o código numerico do caractere
            #endregion

            #region  Conversão explicita.
            //Conversão Explicita = Qundo exist e perca de informações
            //A conversão precisa ser feita somente pela possibilidade de perca.

            //ushort num1 = 500;
            //byte num2 = (byte) num1;

            //float num3 = 2500.786f;
            //int num4 = (int) num3;

            //char letra = (char)97;
            #endregion

            #region Metodo Parse.
            //Parse é mais utilizado para valores de tipo numerico, mas também pode agregar para outros tipos.
            //string txtnumero = "1985";
            //int numero = int.Parse(txtnumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57"); //Em conversões pontos trocar o "." pela ","

            //float num3 = float.Parse("457,75"); //float n precisa da letra "f".
            #endregion

            #region Método Convert.
            string texto = Convert.ToString (2500); //Tenta realizar a conversão de qualquer tipo para qualquer tipo.
            double num1 = Convert.ToDouble (2500);

            int num2 = Convert.ToInt32(num1);
            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
