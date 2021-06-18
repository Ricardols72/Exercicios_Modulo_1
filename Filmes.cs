using System;
using System.Collections.Generic;
using System.Text;

namespace Poo2
{
    class Filmes
    {
        public string Nome;
        public string AtorPrincipal;
        public string Genero;
        public double Duracao;
        public int Ano;


        public void FilmeCartaz()
        {
            
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Genero: " + Genero);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Ator/Atriz Principal: " + AtorPrincipal);
            Console.WriteLine("Duração: " + Duracao + " minutos");
 

        }
    }
}
