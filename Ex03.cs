using System;

namespace Exer03 {
    class Program {
        static void Main(string[] args) {
            double celsius, fahrenheit, aux;
            string resposta;
            
            Console.WriteLine("#######################################");
            Console.WriteLine("#         Graus em Fahrenheit         #");
            Console.WriteLine("#######################################");

            Console.WriteLine("Para qual conversão deseja realizar, Celsius ou Fahrenheit?");
            resposta = Convert.ToString(Console.ReadLine());
            
            if(resposta == "Celsius" || resposta == "celsius") {

                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                aux = Celsius(fahrenheit);
                Console.WriteLine("A conversão de " + fahrenheit + " Fahrenheit em Celsius é:"  + aux + "C");

            }
            else if( resposta == "Fahrenheit" || resposta == "fahrenheit") {
                Console.WriteLine("Digite a temperatura em Celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());
                aux = Fahrenheit(celsius);
                Console.WriteLine("A conversão de " + celsius + "C em Fahrenheit é:" + aux + "F");

            }          
            
        }

        static double Fahrenheit(double c) {
            double f;

            f = (c * 1.8) + 32;
            return f;
        }

        static double Celsius(double f) {
            double c;

            c = (f - 32) / 1.8;
            return c;
        }
    }
}
