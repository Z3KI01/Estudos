using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cinlindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
            //Private = Visivel apenas internamente dentro da Classe
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}
            //Cilindrada = Math.Abs(cilindrada);
            //Math.Abs transforma valor negativo em positivo, e se estiver positivo, mantem igual

            Cilindrada= cilindrada;
        }


         internal class GetSet {
            public static void Executar() {
                var moto1 = new Moto("Yamaha", "Fazer-250", 250);

                Console.WriteLine(moto1.GetMarca());
                Console.WriteLine(moto1.GetModelo());
                Console.WriteLine(moto1.GetCilindrada());

                var moto2 = new Moto();

                moto2.SetMarca("Honda");
                moto2.SetModelo("CB300");
                moto2.SetCilindrada(300);
                Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " +  moto2.GetCilindrada());
            }
        }
    }
}