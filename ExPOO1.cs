using System;

namespace Poo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("#                Projeto POO              #");
            Console.WriteLine("###########################################");

            //Formas diferentes de passagem de atributos e parâmetros

            QuartoHotel quarto = new QuartoHotel();
            Hospede pessoa = new Hospede();
            Filmes filme1 = new Filmes();
            Filmes filme2 = new Filmes();
            Filmes filme3 = new Filmes();


            Console.WriteLine("Bem vindo, vamos realizar o seu checkin: Nos informe alguns dados.");
            Console.Write("Informe seu nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Informe sua altura: ");
            pessoa.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe seu peso: ");
            pessoa.Peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe sua idade: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe seu sexo: ");
            pessoa.Sexo = Convert.ToString(Console.ReadLine());

            Console.Write("\n\n");        
            pessoa.Pessoa();

            filme1.Nome = "Xuxa e os Trapalhões";
            filme1.Genero = "Só Deus sabe";
            filme1.Ano = 1989;
            filme1.AtorPrincipal = "Maria da Graça Xuxa Meneghel";
            filme1.Duracao = 240;

            filme2.Nome = "O tal do filme do Pelé";
            filme2.Genero = "Futebol";
            filme2.Ano = 1980;
            filme2.AtorPrincipal = "Edson Arantes do Nascimento";
            filme2.Duracao = 90;

            filme3.Nome = "Galinha pintadinha 12: Até seus ouvidos sangrarem";
            filme3.Genero = "Punição";
            filme3.Ano = 2077;
            filme3.AtorPrincipal = "Uma galinha que canta";
            filme3.Duracao = 300;


            quarto.PacoteHotel(2,2,"Não","Não","Também não");
            quarto.PacoteEscolhido();

            Console.Write("\n\n");

            Console.WriteLine("Temos um mini cinema em nosso hotel com alguns filmes em cartaz, totalmente incluso no pacote");
            Console.Write("\n\n");
            Console.WriteLine("Estes são os filmes que será obrigado a assistir");
            Console.Write("\n\n");
            filme1.FilmeCartaz();
            Console.Write("\n\n");
            filme2.FilmeCartaz();
            Console.Write("\n\n");
            filme3.FilmeCartaz();
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////

// Arquivos de classes estão externos, apenas para simplificar
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

/////////////////////////////////////////////////////////////////////////////////////////////////////
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
    /////////////////////////////////////////////////////////////////////////////////////////////

    class QuartoHotel
    {
        public int Cama;
        public string Tv;
        public string VistaPraia;
        public string Academia;
        public int Banheiros;

        public void PacoteHotel(int cama, int banheiros, string tv,string vistaPraia, string academia)
        {
           
            Cama = cama;
            Banheiros = banheiros;
            Tv = tv;
            VistaPraia = vistaPraia;
            Academia = academia;
        }

        public void PacoteEscolhido()
        {
            Console.WriteLine("O que sobrou para você foi este quarto!!!");
            Console.WriteLine("Quarto com " + Cama + " camas");
            Console.WriteLine(Banheiros + " Banheiros");
            Console.WriteLine(Tv + " Tv");
            Console.WriteLine(Tv + " Tv");
            Console.WriteLine("Hoje " + Academia + " campeão"); 
        }
    }