using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3B.BackEnd
{
    public class Hrac
    {
        public Pole.Stav Hodnota { get; }

        public Hrac(Pole.Stav hodnota)
        {
            Hodnota = hodnota;
        }
    }
}
