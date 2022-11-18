using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MetodosComRetorno {

        class CalculadoraComum {
            public int Somar(int a, int b) {
                return a + b;
            }

            public int Subtrair(int a, int b) {
                return a - b;
            }

            public int Multiplicar(int a, int b) {
                return a * b;
            }

            public double Dividir (double a, double b) { 
                return a / b;
            }
        }

        class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar(int a) {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Dividir(int a) {
                memoria /= a;
                return this;
            }
            public CalculadoraCadeia Subtrair(int a) {
                memoria -= a;
                return this;
            }

            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }

            public int resultado() {
                return memoria;
            }
        }
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(4 , 8));
            Console.WriteLine(calculadoraComum.Dividir(8 , 4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
        }
    }
}
