using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() {
            Pessoa siclano = new Pessoa();
            siclano.Nome = "Jéssica";
            siclano.Idade = 27;

            //Console.WriteLine($"{siclano.Nome} tem {siclano.Idade} anos.");

            siclano.ApresentarNoConsole();
            siclano.Zerar();
            siclano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Daniela";
            fulano.Idade = 26;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
