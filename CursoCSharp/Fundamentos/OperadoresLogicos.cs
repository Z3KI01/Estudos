using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            //Tabela verdade AND (&&):
            // verdadeiro + verdadeiro = verdadeiro
            //Verdadeiro + falso = falso
            //Falso + verdadeiro = falso
            //Falso + Falso = Falso
            //A expressão AND é verdadeira somente quando ambas as condições sendo comparadas são verdadeiras.


            //Tabela verdade OR (||)
            //Verdadeiro + Verdadeiro = Verdadeiro 
            //Verdadeiro + falso = Verdadeiro 
            //Falso + Verdadeiro = Verdadeiro 
            //Falso + Falos = Falso
            //A expressão OR é verdadeira quando pelo menos uma das condições sendo comparadas é verdadeira.

            //Tabela Verdade XOR (^)
            //Verdadeiro + Verdadeiro = Falso
            //Verdadeiro + Falso = Verdadeiro 
            //Falso + Verdadeiro = Verdadeiro 
            //Falso + Falso = Falso 
            //A expressão XOR é verdadeira quando EXATAMENTE uma das condições sendo comparadas é verdadeira, e é falsa quando ambas são verdadeiras ou ambas são falsas.

            var executouTrabalho1 = false;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comrou o sorvete? {0}", comprouSorvete);

            var comrouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 32? {0}", comrouTv32);

            //Operador Unário
            //! Negação lógica, pega um valor verdadeiro e transforma em falso e assim vice e versa
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    } 
}
