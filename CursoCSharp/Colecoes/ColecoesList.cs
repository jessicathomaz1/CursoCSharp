using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesList {
        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() { 
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 25.9),
                new Produto("Livro - House of the dragon", 79.9),
                new Produto("Redmi Note 11", 1389.9),
            };            

            carrinho.AddRange(combo);
            Console.WriteLine("Quantidade de produtos no carrinho: {0}", carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}
