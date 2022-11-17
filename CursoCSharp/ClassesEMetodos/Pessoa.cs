using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            if(Nome == "" && Idade == 0) {
                return string.Format("Valores não preenchidos!");
            } else {
                return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
