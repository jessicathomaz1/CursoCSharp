using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Daniela";
            alunos[1] = "Jéssica";
            alunos[2] = "Alice";
            alunos[3] = "Vanessa";
            alunos[4] = "Luna";

            //Console.WriteLine(alunos[0]);
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine(media);
        }
    }
}
