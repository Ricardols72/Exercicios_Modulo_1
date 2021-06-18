using System;
using System.Collections.Generic;
using System.Text;

namespace Poo2
{
    public class Hospede
    {

        public int Idade;
        public double Altura;
        public double Peso;
        public string Sexo;
        public string Nome;


        public void Pessoa()
        {
            Console.WriteLine(" Cadastro do hóspede realizado com sucesso:");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Altura: " + Altura);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Sexo: " + Sexo);
        }
    }
}
