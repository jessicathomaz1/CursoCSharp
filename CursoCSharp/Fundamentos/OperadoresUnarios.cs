using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte o sinal - para + ou + para -
            Console.WriteLine(!booleano); // inverte o valor lógico

            numero1++;
            Console.WriteLine(numero1);

            --numero2;
            Console.WriteLine(numero2);

            Console.WriteLine(numero1++ == --numero2);
        }
    }
}
