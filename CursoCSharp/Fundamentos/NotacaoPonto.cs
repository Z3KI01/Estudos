using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            //nil
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // Tomar cuidado em usar a notação ponto em variaveis sem valor / null
            //Usar o ? vai fazer com que o console só seja exibido se estiver com um valor atribuido ao mesmo <> de vazio
        }
    }
}
