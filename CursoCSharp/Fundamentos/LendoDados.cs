using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            
            //Técnica simples usada para que o usuário insira valores na variável de forma manual.
            Console.Write("Qual é o  seu nome? ");
            string nome = Console.ReadLine();

            //Mesma situação, desta vez tendo relação com a idade, porém, a variável idade uma mostrada como uma string, portanto, utiliza-se o Parse para converter uma string para valor real.
            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            //Em conjunto com o "using System.Globalization;", podemos fazer com que o a notação que separe valores como o salário não sejam mais a virgula, e sim o ponto, inserindo "CultureInfo.InvariantCulture"
            Console.Write("Qual é o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R$ {salario}");
        }
    }
}
