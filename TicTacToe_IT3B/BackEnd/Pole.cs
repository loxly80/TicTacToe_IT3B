using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe_IT3B.BackEnd
{
    public class Pole
    {
        public Stav Hodnota { get; set; }

        public Pole()
        {
            Hodnota = Stav.Prazdny;            
        }

        public enum Stav
        {
            Prazdny,
            Kolecko,
            Krizek
        }

        public override string ToString()
        {
            if (Hodnota == Stav.Prazdny)
            {
                return "";
            }
            else if (Hodnota == Stav.Krizek)
            {
                return "X";
            }
            else
            {
                return "O";
            }            
        }
    }
}
