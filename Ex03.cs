using System;


namespace MDC {
    class Program {
        static void Main(string[] args) {

            int num1, num2, aux;
            

            Console.WriteLine("###################################################");
            Console.WriteLine("#                     MDC                         #");
            Console.WriteLine("###################################################");




            Console.WriteLine("Informe o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            aux = Mdc(num1, num2);

            Console.WriteLine("O M.D.C para " + num1 + " e " + num2 + " é: " + aux);
           
        }


        static int Mdc(int a, int b) {
            int divisor, dividendo, rest;
            
            
            if (a == 0 || b == 0)
                Console.WriteLine("Erro, valor = 0");

            if (a > b) {
                dividendo = a;
                divisor = b;

            } else {
                dividendo = b;
                divisor = a;
            }
            while (dividendo % divisor != 0) {
                rest = dividendo % divisor;
                dividendo = divisor;
                divisor = rest;
            }
             return divisor;
        }

    }
}
