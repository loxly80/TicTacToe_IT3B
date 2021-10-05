using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_IT3B.BackEnd;

namespace TicTacToe_IT3B
{
    public partial class Form1 : Form
    {
        private Button[] tlacitka;
        private Hra hra;

        public Form1()
        {
            InitializeComponent();
            hra = new Hra();
            hra.StavZmenen += RefreshGUI;
            tlacitka = new Button[9];
            tlacitka[0] = b1;
            tlacitka[1] = b2;
            tlacitka[2] = b3;
            tlacitka[3] = b4;
            tlacitka[4] = b5;
            tlacitka[5] = b6;
            tlacitka[6] = b7;
            tlacitka[7] = b8;
            tlacitka[8] = b9;
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            for (int i = 0; i < hra.Plocha.Length; i++)
            {
                tlacitka[i].Text = hra.Plocha[i].ToString();
            }
            var vyherce = hra.JeVitez();
            if(vyherce != Pole.Stav.Prazdny)
            {
                MessageBox.Show($"Vyhral {vyherce}");
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(0);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(1);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(2);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(3);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(4);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(5);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(6);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(7);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            hra.ProvedTah(8);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (hra != null) hra.StavZmenen -= RefreshGUI;
            hra = new Hra();
            hra.StavZmenen += RefreshGUI;
            RefreshGUI();
        }
    }
}
