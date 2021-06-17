using System;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {

            int mes;
             int resultado;
            
            
            Console.WriteLine("#########################################################");
            Console.WriteLine("#             Calculadora de dias em meses              #");
            Console.WriteLine("#########################################################");

            Console.Write("Por favor, informe quanto(s) mes(es) deseja saber a quantidade de dia(s): ");
            mes = Convert.ToInt32(Console.ReadLine());

            resultado =  Calculadora(mes);
            Console.WriteLine("A quantidade de dias para " + mes + " mes(s) é: " + resultado);

        }
        static int Calculadora(int m) {
            int aux;

            aux = m * 30;


            return aux;
        }
    }
}
