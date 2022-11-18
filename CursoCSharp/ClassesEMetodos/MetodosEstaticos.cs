using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {

        // Só acessível pela classe
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // acessível pela instancia
        public int Somar(int a, int b) {
            return a + b;
        }

    }
    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
