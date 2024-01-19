using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            
            //Conversão Implicita, não houve perca de dados
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão explicita;
            // A expressão (int) é uma operação de casting que converte explicitamente o valor de nota para um número inteiro, removendo a parte decimal
            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            //int.Parse() = Isso assume que o usuário digitou uma representação válida de um número inteiro. Se a entrada não puder ser convertida para um número inteiro, isso resultará em uma exceção.
            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int IdadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", IdadeInteiro);

            //Convert.ToInt32(). Este método faz uma conversão segura, evitando uma exceção se a string não puder ser convertida para um número inteiro. Se a conversão não for bem-sucedida, o método retornará zero.
            IdadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", IdadeInteiro);


            //int.TryParse(). Este método tenta realizar a conversão e retorna um booleano indicando se a conversão foi bem-sucedida. Se for bem-sucedida, o resultado é armazenado na variável numero1.
            Console.Write("Digite o primeiro número:");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            //Mesma coisa do exemplo de cima, porém mais simplificado.
            Console.Write("Digite o segundo numero:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
