using System;

namespace Exer08 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("######################################################");
            Console.WriteLine("#          Ordenando números em um array             #");
            Console.WriteLine("######################################################");

            int[] array = new int[10];
            int numero;

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Informe um número");
               numero = Convert.ToInt32(Console.ReadLine());
                array[i] = numero;  
            }

            Console.WriteLine("Array ordenado");

            Array.Sort(array);

            foreach (int value in array) Console.WriteLine("[" + value + "]");

            Console.ReadLine();  
        }

    }
}

