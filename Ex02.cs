using System;

namespace Ex02 {
    class Program {
        static void Main(string[] args) {

            double salario;
            double porcentagem;
            double novoSalario;

            Console.WriteLine("#####################################################");
            Console.WriteLine("#                 Reajuste Salarial                 #");
            Console.WriteLine("#####################################################");


            Console.Write("Por favor, informe o salário base: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora informe o valor do reajuste: ");
            porcentagem = Convert.ToDouble(Console.ReadLine());


            novoSalario = Reajuste(salario, porcentagem);

            Console.WriteLine("O seu novo salário com rejuste de " + porcentagem + "% é de: " + novoSalario);

        }

        static double Reajuste(double s, double p) {

            double novoSal;

            novoSal = s +((p * s)/100);
            
            
            return novoSal;
        }
    }
}
