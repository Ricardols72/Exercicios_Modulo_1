using System;

namespace Exe04 {
    class Program {
        static void Main(string[] args) {
            double valor1, valor2, valor3;




            Console.WriteLine("###############################################");
            Console.WriteLine("#                Bhaskara                     #");
            Console.WriteLine("###############################################");


            Console.WriteLine("Informe 3 valores para realizar o cálculo: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            valor2 = Convert.ToDouble(Console.ReadLine());
            valor3 = Convert.ToDouble(Console.ReadLine());

            double delta = (valor2 * valor2) - (4 * valor1 * valor3);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(valor2)) + raiz) / (2 * valor1);
            var x2 = ((-(valor2)) - raiz) / (2 * valor1);

            Console.WriteLine("Valor de X: " + x1 + " Valor de X: " + x2);

        }




    }
}
