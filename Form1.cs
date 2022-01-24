using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        String cerchioCroce = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                cerchioCroce = "X";
            else
                cerchioCroce = "O";

            nuovoGioco();
        }

        void generaRandom()
        {
            String segnoOpposto = "";

            if (cerchioCroce == "X")
                segnoOpposto = "O";
            else
                segnoOpposto = "X";

            //genero il segno opposto in una label random, esclusa quella appena cliccata
            Random r = new Random();
            int randomNum = r.Next(1, 9);

            if (randomNum == 1)
            {
                if (label1.Text == "")
                    label1.Text = segnoOpposto;
                else
                    randomNum++;

            }
            else if (randomNum == 2)
            {
                if (label2.Text == "")
                    label2.Text = segnoOpposto;
                else
                    randomNum++;
            } else
            if (randomNum == 3)
            {
                if (label3.Text == "")
                    label3.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 3)
            {
                if (label3.Text == "")
                    label3.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 4)
            {
                if (label4.Text == "")
                    label4.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 5)
            {
                if (label5.Text == "")
                    label5.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 6)
            {
                if (label6.Text == "")
                    label6.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 7)
            {
                if (label7.Text == "")
                    label7.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 8)
            {
                if (label8.Text == "")
                    label8.Text = segnoOpposto;
                else
                    randomNum++;
            }
            else
            if (randomNum == 9)
            {
                if (label9.Text == "")
                    label9.Text = segnoOpposto;
                else
                    randomNum++;
            }


        }

        void controllaVincita()
        {
            Boolean vinto = false;

            //=============Controllo vincita in orizzontale
            if (label1.Text == cerchioCroce && label2.Text == cerchioCroce && label3.Text == cerchioCroce)
                vinto = true;

            if (label4.Text == cerchioCroce && label5.Text == cerchioCroce && label6.Text == cerchioCroce)
                vinto = true;

            if (label7.Text == cerchioCroce && label8.Text == cerchioCroce && label9.Text == cerchioCroce)
                vinto = true;

            //=============controllo vincita in verticale
            if (label1.Text == cerchioCroce && label4.Text == cerchioCroce && label7.Text == cerchioCroce)
                vinto = true;

            if (label2.Text == cerchioCroce && label5.Text == cerchioCroce && label8.Text == cerchioCroce)
                vinto = true;

            if (label3.Text == cerchioCroce && label6.Text == cerchioCroce && label9.Text == cerchioCroce)
                vinto = true;

            //=============controllo vincita in obliquo
            if (label1.Text == cerchioCroce && label5.Text == cerchioCroce && label9.Text == cerchioCroce)
                vinto = true;

            if (label3.Text == cerchioCroce && label5.Text == cerchioCroce && label7.Text == cerchioCroce)
                vinto = true;


            if (vinto == true)
            {
                MessageBox.Show("Hai vinto!");
                nuovoGioco();
            }
        }

        void nuovoGioco()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "")
            label1.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
                label2.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
                label3.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
                label4.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
                label5.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
                label6.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
                label7.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
                label8.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
                label9.Text = cerchioCroce;

            generaRandom();
            controllaVincita();
        }
    }
}
