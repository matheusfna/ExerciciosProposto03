using System;
using System.Globalization;

namespace ExerciciosProposto03 {
    class URI {
        static void Main(string[] args) {

            int n;

            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            //Vetor A
            string[] valor = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++) {
                a[i] = int.Parse(valor[i]);
            }

            //Vetor B com
            valor = Console.ReadLine().Split(' ');
            for(int i = 0; i < n; i++) {
                b[i] = int.Parse(valor[i]);
            }

            //Criando o Vetor C para fazer a soma do A + B
            int[] c = new int[n];

            for(int i = 0; i < n; i++) {
                c[i] = a[i] + b[i];
            }

            //Mostrando a soma dos vetores A + B na tela
            for(int i = 0; i < n; i++) {
                Console.WriteLine(c[i] + " ");
            }
        }
    }
}



