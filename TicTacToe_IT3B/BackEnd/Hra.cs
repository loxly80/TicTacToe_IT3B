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

        public Action StavZmenen;

        private Random random = new Random();

        public Hra()
        {
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
    }
}
