using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Variáveis {
    internal class Program {

        #region enum.
        //enum Notas { 
        //    Minimo = 10,
        //    Media = 20,
        //    Maxima = 30 //Funciona com sistema de indexação, portanto, vai enumerando, 0,1,2,3.... Isso de acordo com as declarações dentro do Num.
        //        //Posso usar Enum para tratar mensagens de erros
        //        //Se eu deninir um valor fixo, ele atribui a sequência da ordem dos valores.
        //}
        #endregion

        #region Struct.

        //struct Pessoa {
        //    public string nome; //Não podemos inicializar as variáveis na struct
        //    public int idade;
        //    public double altura;



        //}
        #endregion
        static void Main(string[] args) {
            #region Numericas integrais.
            //    //Integral assinado (com sinal, numero negativo)
            //    sbyte num1 = 10; // 8 bits, de -128 a 127
            //    short num2 = 20; // 16 bits, -32.768 a 32.767
            //    int num3 = 30; // 32 bits, - 9.223.372.036.854.775.808 a 9.223.036.854.775.807
            //    long num4 = 40L; //64 bits, - 223.372.036.854.775.808 a9.223.372.036.854.775.807

            //    //Integral sem sinal
            //    byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //    ushort num6 = 20; // 16 bits, de 0 a 65.535
            //    uint num7 = 30; // 32 bits, de 0 a 4.294.967.295
            //    ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //    sbyte numero;            numero = 100;
            //    //Posso atribuir antes ou depois

            //    numero = 120; // Realizei alteração sobre a variavel numero
            //    numero = num1; //Realizei uma cópia referenciando uma variável na outra
            #endregion

            #region Numeros Reais.
            //float real1 = 100.75f; //32 bits, precisa de letra auxiliar.
            //double real2 = 500.754; // 64 bits.
            //decimal real3 = 752538.457m; // Precisa do sufixo M

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere.
            //char letra = '\u0061';
            //char escape = '\n'; //quebra de linha
            //char literal = 'a';
            //É possivel acrescentar também os códigos dispostos na tabela UTF 16;
            #endregion

            #region Boll.
            //bool verificar = false;
            //verificar = true;
            // Verdadeiro ou Falso, mas normalmente usado mais em expreções
            #endregion

            #region String.
            //String é uma coleção de caracteres do tipo char
            //Valor padrão null
            //string texto;
            //texto = @"Ana clara\nde Oliveira"; //@ Anula caracteres especiais
            //string mensagem = null;
            //mensagem = texto;
            //Não primitivo, possivel usar a notação ponto.
            #endregion

            #region Var / Inferência.
            //var valor = 140; // Inferência
            //valor = 20;
            #endregion

            #region Object.
            //object obj = false;
            //obj = 200;
            //obj = "Ana Clara";
            //Object pode armazenar qualquer coisa
            #endregion

            #region Const.
            //const double pi = 3.1415; // Constante, não muda, não pode ser alterado
            //const string nome = "Ana Clara";
            #endregion

            #region Enum.
               //Notas notasAlunos = Notas.Media;
            #endregion

            #region struct.
            //Pessoa p1 = new Pessoa();
            //p1.altura = 1.84;
            //p1.idade = 18;
            //p1.nome = "Ezequiel";

            //Pessoa p2 = new Pessoa()
            //{
            //    nome = "Ana",
            //    idade = 17,
            //    altura = 1.55
            //}; // Se abrir chaves na para definir um valor para as variáveis da struct, precias inserir um ";" posterior a }

            //p1.nome = "Logan";
            #endregion

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
           
        }
    }
}