using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome; //PascalCase = Letra maiscula em cada palavra 
        public int Idade; //String tem valor padrão null, Int tem valor 0
        //Quando trabalhar com atributos dentro de metodos, inicia-se com a letra minuscula, em classe, primeira letra maiscula 
        
        public string Apresentar() {
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "0";
            Idade = 0;

        }
    }
}
