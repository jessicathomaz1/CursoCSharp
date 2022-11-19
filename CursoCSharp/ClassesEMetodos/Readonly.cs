using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Readonly {
        public class Cliente {
            // Atributos
            public string Nome;
            readonly DateTime Nascimento;

            //Construtor
            public Cliente(string nome, DateTime nascimento) {
                Nome = nome;
                Nascimento = nascimento;
            }

            // Métodos
            public string GetDataNascimento() {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar() {
            var novoCliente = new Cliente("Jéssica", new DateTime(1994, 9, 1));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}
