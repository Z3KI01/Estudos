using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;
        //Serve para apontar um valor imutável na declaração somente para leitura

        public Cliente (string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDatadeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Clara", new DateTime(2006, 12, 14));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDatadeNascimento());
        }
    }
}
