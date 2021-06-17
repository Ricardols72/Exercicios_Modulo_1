using System;

namespace Exe04 {
    class Program {
        static void Main(string[] args) {
            double valor1, valor2, valor3, aux;




            Console.WriteLine("###############################################");
            Console.WriteLine("#                Bhaskara                     #");
            Console.WriteLine("###############################################");


            Console.WriteLine("Informe 3 valores para realizar o cálculo: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            valor2 = Convert.ToDouble(Console.ReadLine());
            valor3 = Convert.ToDouble(Console.ReadLine());

            double delta1 = Math.Sqrt(valor2 * valor2);
            double delta2 = Math.Sqrt(4 * valor1 * valor3);

            double delta = (delta1 - delta2);

            double num1 = (-valor2 + (delta)) / (2 * valor1);
            double num2 = (-valor2 - (delta)) / (2 * valor1);


            Console.WriteLine("resultado 1 " + num1 + " e resultado 2 " + num2);
          
        }




    }
}
