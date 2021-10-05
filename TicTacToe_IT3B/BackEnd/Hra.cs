using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3B.BackEnd
{
    public class Hra
    {
        public Hrac Hrac1 { get; set; }
        public Hrac Hrac2 { get; set; }
        public Pole[] Plocha { get; set; }
        public Hrac NaTahu { get; set; }

        private List<int[]> vyherniKombinace = new List<int[]>() {
            new int[3] { 0, 1, 2 }
           ,new int[3] { 3, 4, 5 }
           ,new int[3] { 6, 7, 8 }
           ,new int[3] { 0, 3, 6 }
           ,new int[3] { 1, 4, 7 }
           ,new int[3] { 2, 5, 8 }
           ,new int[3] { 0, 4, 8 }
           ,new int[3] { 2, 4, 6 }
        };

        public Action StavZmenen;

        private Random random = new Random();

        public Hra()
        {

            int[] test0 = new int[3] { 2, 4, 6 };

            int[] test = new int[3];
            test[0] = 2;
            test[1] = 4;
            test[2] = 6;



            Hrac1 = new Hrac(Pole.Stav.Kolecko);
            Hrac2 = new Hrac(Pole.Stav.Krizek);
            if (random.NextDouble() > 0.5)
            {
                NaTahu = Hrac1;
            }
            else
            {
                NaTahu = Hrac2;
            }
            Plocha = new Pole[9];
            for (int i = 0; i < 9; i++)
            {
                Plocha[i] = new Pole();
            }
        }

        public void ProvedTah(int indexPole)
        {
            if (Plocha[indexPole].Hodnota == Pole.Stav.Prazdny)
            {
                Plocha[indexPole].Hodnota = NaTahu.Hodnota;
                if (NaTahu == Hrac1)
                {
                    NaTahu = Hrac2;
                }
                else
                {
                    NaTahu = Hrac1;
                }
                StavZmenen?.Invoke();
            }
        }

        public Pole.Stav JeVitez()
        {
            Pole.Stav stav;
            foreach (var kombinace in vyherniKombinace)
            {
                stav = Plocha[kombinace[0]].Hodnota;
                if (stav != Pole.Stav.Prazdny && stav == Plocha[kombinace[1]].Hodnota && stav == Plocha[kombinace[2]].Hodnota)
                {
                    return stav;
                }
            }
            return Pole.Stav.Prazdny;
        }
    }
}
