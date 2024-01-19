using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        //Interpolação seria a funcionalidade de poder inserir variáveis ou expressões diretamene em uma string sem a necessidade de usar operadores como + por ex
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            //Aqui estou usando o operador + para concatenar
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + "." );

            //Aqui estou usando {1,2 e 3} para atribuir valores as variaveis declaradas posteriormente as strings
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            //Aqui estou usando o caractere $ para poder usar o nome da variavel no meio da string sem precisar usar um operador, posso usar o mesmo exemplo para inserir um expressão matematica, como 1+1 = 2.
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        } 
    }
}
