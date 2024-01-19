using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            //F1 fará que com que o numero seja formatado usando a notação de ponto usando UMA casa decimal apenas.
            Console.WriteLine(valor.ToString("F1"));

            //O "C" indica que o formato a ser convertido na string deve ser de moeda.
            Console.WriteLine(valor.ToString("C"));

            //O "P" converte o valor numérico em uma representação de string formatada como porcentagem.
            Console.WriteLine(valor.ToString("P"));

            //o # deixará claro a forma como a string deve ser exibida, nesse caso, com duas casas decimais.
            Console.WriteLine(valor.ToString("#.##"));

            //C3 indifca que o numero deve ser formatado com 3 casas decimais
            //Cultureinfo = Representa a cultura de um país, implicando diretamente sobre a formataçãop de exibição do simbolo da moeda no caso desse exemplo abaixo.
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
