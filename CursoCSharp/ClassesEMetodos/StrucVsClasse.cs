using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    internal class StrucVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto {X=1, Y=3};
            SPonto copiaPonto1 = ponto1; //Atribuição por valor!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X=2, Y=4};
            CPonto copiaPonto2 = ponto2;//Atribuição por referência
            ponto2.X = 4;

            Console.WriteLine("Ponto 2X:{0}",ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}",copiaPonto2.X);

            // Atribuição por Valor: Quando cria-se uma cópia, você está realmente duplicando os dados, modificando um ponto não se afeta ao outro.

            //Atribuição por Referência : Quando você cria uma cópia, você está apenas copiando a referência e não os dados reias, portanto, ao modificar um ponto,a  outra referência também se altera.

        }
    }
}
