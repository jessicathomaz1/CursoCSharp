using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        // Construtor
        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        // Construtor padrão
        public Carro() {

        }
    }
    internal class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "352i";
            carro1.Ano = 2020;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

        }
    }
}
