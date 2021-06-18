using System;
using System.Collections.Generic;
using System.Text;

namespace Poo2
{
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
}
