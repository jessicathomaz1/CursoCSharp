using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Propriedades {
        public class CarroOpcional {
            double desconto = 0.1;

            string nome;
            public string Nome {
                get {
                    return "Opcional: " + nome;
                }
                set {
                    nome = value;
                }
            }

            // Propriedade autoimcrementada
            public double Preco { get; set; }

            // Somente leitura
            public double PrecoComDesconto {
                get => Preco - (desconto * Preco); // lambda
                //get {
                //    return preco - (desconto * preco);
                //}
            }

            public CarroOpcional() {
                
            }

            public CarroOpcional(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.0);
            //Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 3249.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto);
            
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
