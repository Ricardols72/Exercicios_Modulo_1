using System;

namespace Exe09 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("#########################################################");
            Console.WriteLine("#                Percentual de votos                    #");
            Console.WriteLine("#########################################################");
            
            string aux;

            PercVotos obj = new PercVotos();

            Console.WriteLine("Informe o total de votos");
            obj.total = Convert.ToInt32(Console.ReadLine());

            do {

                Console.WriteLine("Qual percentual de votos deseja saber: [v] válidos, [b] brancos, [n] nulos");
                aux = Convert.ToString(Console.ReadLine());

                if (aux == "v") {
                    Console.WriteLine("Informe o número de votos válidos");
                    obj.validos = Convert.ToInt32(Console.ReadLine());
                    obj.Validos();
                } else if (aux == "b") {
                    Console.WriteLine("Informe o total de votos em branco");
                    obj.brancos = Convert.ToInt32(Console.ReadLine());
                    obj.Brancos();
                } else if (aux == "n") {
                    Console.WriteLine("Informe o total de votos nulos");
                    obj.nulos = Convert.ToInt32(Console.ReadLine());
                    obj.Nulos();
                }
                Console.WriteLine("Digite sair para finalizar ou aperte a tecla Enter para saber outro percentual com relação a " + obj.total + " votos.");
                aux = Convert.ToString(Console.ReadLine());

            } while (aux != "sair");
        }
    }
}
// Classe para cálculo do percentual de votos

namespace Exe09 {
    class PercVotos {

        public float total;
        public float validos;
        public float brancos;
        public float nulos;

        public void Validos() {
            float perc = validos / total * 100;
            Console.WriteLine("Votos válidos é de: " + perc + "% com relação a " + total + " eleitores");
        }
        public void Brancos() {
            float perc = brancos / total * 100;
            Console.WriteLine("Votos em branco é de: " + perc + "% com relação a " + total + " eleitores");
        }
        public void Nulos() {
            float perc = nulos / total * 100;
            Console.WriteLine("Votos em nulo é de: " + perc + "% com relação a " + total + " eleitores");
        }
    }
}
