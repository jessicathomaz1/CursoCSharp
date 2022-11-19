using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesArrayList {
        public static void Executar() {
            var arrayLit = new ArrayList {
                "Palavra",
                3,
                true
            };

            arrayLit.Add(3.14);

            foreach(var item in arrayLit) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
