using System;

namespace Ex07 {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("##################################################");
            Console.WriteLine("#      Empilhar números e inverter posição       #");
            Console.WriteLine("##################################################");


            int[] array = new int[10];
            int numero;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());

                array[i] = numero;
            }

            Console.WriteLine("Posição inicial da pilha.");

            foreach (int value in array)  Console.WriteLine("[" + value + "]");
            

            Array.Reverse(array);

            Console.WriteLine("Posição invertida da pilha.");
            foreach (int value in array)  Console.WriteLine("[" + value + "]");
            

            Console.ReadKey();

            //Forma manual de inverter um array
/*
            Console.WriteLine("Posição inicial da pilha.");
            for (int i = 0; i < 10; i++) {

                Console.WriteLine("[" + array[i] + "]");
            }

            Console.WriteLine("Posição invertida da pilha.");
            for (int i = 9; i >= 0; i--) {
                Console.WriteLine("[" + array[i] + "]");
            }
*/
        }
    }
}
