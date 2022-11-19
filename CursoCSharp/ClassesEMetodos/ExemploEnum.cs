using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExemploEnum {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

        public class Filme {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "Crepúsculo";
            filme.GeneroDoFilme = Genero.Aventura;

            Console.WriteLine("O filme {0} é do gênero {1}", filme.Titulo, filme.GeneroDoFilme);
        }
    }
}
