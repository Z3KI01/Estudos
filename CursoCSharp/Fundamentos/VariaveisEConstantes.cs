using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferbencia
            //Double é usado para usar numeros com casas decimais 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            //Verdadeiro ou falso, boleano, true = verdadeiro, false = falso
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            //Armazena byte
            //0 a 256
            byte idade = 45;
            Console.WriteLine("Idade " + 45);

            //Armazena byte com sinais, valores negativos por exemplo
            // -128 a 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            //Usado para armazenar valores inteiros curtos, varia de -32.768 a 32.767.
            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            //Armazena valors inteiros
            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            //Armazena apenas valores positivos ou zero
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            //Armazena numeros inteiros longos, que podem ter valores muito  pequenos ou muito grandes
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long" + menorValorLong);

            //Armazena apenas valores positivos ou zero, seguindo o padrão do long
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            //Precisa colocar f no final do valor para não cair dentro da variável do tiplo duble
            //É usada para armazenar numeros que tem parte decimal, como preço ou altura.
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);
            
            //Armazena numeros decimais
            double valorDeMercadoDaApple = 1000000000000000.00; //Mais usado dos reias!
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            //Usado para armazenar decimais de alta precisão, alto valor
            decimal distanciaEntreEstelas = decimal.MaxValue;
            Console.WriteLine("Disntância entre Estrelas " + distanciaEntreEstelas);

            //Usado para armazenar caracteres individuais 
            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            //Usado para armezanar uma cadeia de caracteres
            string texto = "Seja bem vindo ao Curso De C#";
            Console.WriteLine(texto);







        } 
    }
}
