using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Carteira {
        private int dinheiro;
        public int Dinheiro { get; set; }

        //public int Dinheiro;
        //    //get {
        //    //    return dinheiro;    
        //    //}
        //    //set {
                
        //    //}
        //}
    }
    internal class YtGetSet {
        public static void Executar() {
            
            Carteira cart = new Carteira();

            cart.Dinheiro = 50;

            Console.WriteLine("O saldo é: {0} ", cart.Dinheiro);

        }
    }
}
