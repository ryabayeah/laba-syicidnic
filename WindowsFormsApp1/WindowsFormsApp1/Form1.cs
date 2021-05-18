using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int step;
        static int lenght = 4;
        Comand[] comands = new Comand[lenght * 2];
        Comand[] comands1 = new Comand[lenght];
        Comand[] comands2 = new Comand[lenght];

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;
            for (int i = 0; i < 4; i++)
            {
                comands1[i] = new Comand();
                comands1[i].name = "Team " + (i + 1);
            }

            for (int i = 0; i < 4; i++)
            {
                comands2[i] = new Comand();
                comands2[i].name = "Team " + (i + 5) ;
            }

            step = 0;
            teams.Text = "Team 1\n\nTeam 2\n\nTeam 3\n\nTeam 4\n\nTeam 5\n\nTeam 6\n\nTeam 7\n\nTeam 8\n\n";
        }

        private int calcDistr(Comand comandos)
        {
            int m = 0;
            double S = 0;
            var lambda = comandos.srednee;
            while (S >= -lambda)
            {
                double alfa = Tools.generateRandomDouble();
                S += Math.Log(alfa);
                m++;
            }

            return m;

        }
        private void draw()
        {
            for (int i = 0; i < 4; i++)
            {
                comands[i] = comands1[i];
                comands[i + 4] = comands2[i];
            }
            draws.Text = ""; looses.Text = "";
            wins.Text = ""; goals.Text = "";
            teams.Text = ""; points.Text = "";
            Tools.BubbleSort(comands);
            for (int i = 0; i < 8; i++)
            {
                points.Text += $"{comands[i].Points}\n\n";
                teams.Text += $"{comands[i].name}\n\n";
                goals.Text += $"{comands[i].Balls}\n\n";
                wins.Text += $"{comands[i].Win}\n\n";
                looses.Text += $"{comands[i].Lose}\n\n";
                draws.Text += $"{comands[i].Draw}\n\n";
            }
            
        }
        private void results(Comand comand1, Comand comand2)
        {
            (var result1, var result2) = (calcDistr(comand1), calcDistr(comand2));
            if (result1 > result2)
            {
                comand1.Win += 1;
                comand1.Points += 3;
                comand2.Lose += 1;
            }
            else if (result1 < result2)
            {
                comand2.Win += 1;
                comand2.Points += 3;
                comand1.Lose += 1;
            }
            else
            {
                comand1.Points += 1;
                comand1.Draw += 1;
                comand2.Points += 1;
                comand2.Draw += 1;
            }
            comand1.Balls = result1;
            comand2.Balls = result2;
        }
    
        private void firstPart()
        {
            for (int i = 0; i < 4; i++)
            {
                results(comands1[i], comands2[(i + step) % 4]);
            }
            //for (int i = 0; i < 4; i++)
            //{
            //    (var result1, var result2) = (calcDistr(comands1[i]), calcDistr(comands2[(i + step) % 4]) );
            //    if (result1 > result2)
            //    {
            //        comands1[i].Win += 1;
            //        comands1[i].Points += 3;
            //    }
            //    else if (result1 < result2)
            //    {
            //        comands2[(i + step) % 4].Win += 1;
            //        comands1[(i + step) % 4].Points += 3;
            //    }
            //    else
            //    {
            //        comands1[i].Points += 1;
            //        comands1[i].Draw += 1;
            //        comands1[(i + step) % 4].Points += 1;
            //        comands1[(i + step) % 4].Draw += 1;
            //    }
            //    comands1[i].Balls = result1;
            //    comands1[(i + step) % 4].Balls = result2;
            //}
        }

        private void secondPart()
        {
            for(int i=0;i<2;i++)
            {
                var tmp = comands1[i + 2];
                comands1[i + 2] = comands2[i];
                comands2[i] = tmp;
            }

            for (int i = 0; i < 4; i++)
            {
                results(comands1[i], comands2[i]);
            } 
        }

        private void thirdPart()
        {
            var tmp = comands2[1];
            comands2[1] = comands2[0];
            comands2[0] = tmp;

            tmp = comands2[2];
            comands2[2] = comands2[3];
            comands2[3] = tmp;

            for (int i = 0; i < 4; i++)
            {
                results(comands1[i], comands2[i]);
            }
        }

        private void finalPart()
        {
            var tmp = comands2[0];
            comands2[0] = comands2[1];
            comands2[1] = tmp;

            tmp = comands1[1];
            comands1[1] = comands2[0];
            comands2[0] = tmp;

            tmp = comands1[3];
            comands1[3] = comands2[3];
            comands2[3] = tmp;

            tmp = comands2[2];
            comands2[2] = comands2[3];
            comands2[3] = tmp;

            for (int i = 0; i < 4; i++)
            {
                results(comands1[i], comands2[i]);
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (step < 4)
            {
                button1.Text = "Next";
                firstPart();
                step++;
                draw();
            }
            else if(step == 4)
            {
                secondPart();
                step++;
                draw();
            }
            else if (step == 5)
            {
                thirdPart();
                step++;
                draw();
            }
            else if(step == 6)
            {
                finalPart();    
                if (comands[0].Points == comands[1].Points)
                {
                    results(comands[7], comands[6]);
                }
                draw();
                winner.Text = $"The winner is {comands[0].name}";
                button1.Enabled = false;
            }
            
            
        }
    }


    public class Comand
    {
        public string name { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
        public int Points { get; set; }
        public int Balls { get; set; }
        public double srednee { get; set; }
        public Comand()
        {
            srednee = Tools.generateRandom();
            Win = Lose = Draw = Points = Balls = 0;
        }
    }

    static class Tools
    {
        static Random rand = new Random();
        public static double generateRandomDouble()
        {
            return rand.NextDouble();
        }
        public static double generateRandom()
        {
            
            return Math.Round(rand.NextDouble() + rand.Next(0,4),1);
        }
        public static Comand[] BubbleSort(Comand[] mas)
        {
            Comand temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j + 1].Points > mas[j].Points)
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
