using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraVesalaS
{
    public partial class Form1 : Form
    {
        int i = 0;
        string word;
        string[] solution;
        char guess;
        string stringSolution;
        int badguess = 0;
        int goodguess = 0;
        public Form1()
        {
            InitializeComponent();
            word = "ovesajse";
            solution = new string[word.Length];
            MakeSolutionStrg();
        }

        public void MakeSolutionStrg()
        {
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                solution[i] = "_" + " ";
                stringSolution = temp + solution[i];
                temp = stringSolution;
            }
            label2.Text = stringSolution;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            bool trazi = false;
            guess = rec.Text[0];
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].CompareTo(guess) == 0)
                {
                    solution[i] = guess.ToString();
                    goodguess++;
                    if (goodguess == word.Length)
                    {
                       MessageBox.Show( "Pobedili ste!");
                        
                    }
                    trazi = true;
                }
                stringSolution = temp + solution[i];
                temp = stringSolution;
            }
            if (trazi == false)
            {
                badguess++;
                if (badguess == 1)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap1 = new Bitmap(Properties.Resources.Glava);
                    g.DrawImage(bitmap1, 465, 120, 330, 99);

                }
                if (badguess == 2)
                {
                    Graphics g = panel1.CreateGraphics();
                    Bitmap bitmap2 = new Bitmap(Properties.Resources.Telo);
                    g.DrawImage(bitmap2, 475, 195, 297, 234);
                }
                if (badguess == 3)
                {
                    Graphics g2 = panel1.CreateGraphics();
                    Bitmap bitmap3 = new Bitmap(Properties.Resources.NogaLeva);
                    g2.DrawImage(bitmap3, 448, 355, 307, 192);
                }
                if (badguess == 4)
                {
                    Graphics g3 = panel1.CreateGraphics();
                    Bitmap bitmap4 = new Bitmap(Properties.Resources.DNoga);
                    g3.DrawImage(bitmap4, 626, 348, 127, 185);
                }
                if (badguess == 5)
                {
                    Graphics g4 = panel1.CreateGraphics();
                    Bitmap bitmap5 = new Bitmap(Properties.Resources.RukaLeva);
                    g4.DrawImage(bitmap5, 390, 225, 227, 122);
                }
                if (badguess == 6)
                {
                    Graphics g5 = panel1.CreateGraphics();
                    Bitmap bitmap6 = new Bitmap(Properties.Resources.RukaDesna);
                    g5.DrawImage(bitmap6, 628, 226, 180, 122);
                    MessageBox.Show( "Izgubili ste!");
                  
                }
            }
            label2.Text = stringSolution;
        }      
    }
}
