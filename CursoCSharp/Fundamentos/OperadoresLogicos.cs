using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV de 50? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV de 32? {0}", comprouTV32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
