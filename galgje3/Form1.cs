using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galgje3
{
    public partial class Form1 : Form
    {

        string tekst;
        int lengteVanTekst;
        int aantalFouten;
        int aantalBlinken;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startVanSpeeltje();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            buttonCheck.Visible = true;
            textBoxCheck.Visible = true;
          

            tekst = textBoxRaadsel.Text;
            lengteVanTekst = tekst.Length;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lengteVanTekst; i++)
            {
                sb.Append("*  ");
            }
            labelword.Text = sb.ToString();

            labelword.Visible = true;
            MessageBox.Show("Speler 2 raad letter. Als hij de woord al weet, klik hij op raden");

        }
        private void startVanSpeeltje()
        {
            labelword.Visible = false;
            groupBox1.Visible = false;
            textBoxCheck.Visible = false;
            buttonCheck.Visible = false;
            aantalBlinken = 0;
            aantalFouten = 0;
            textBoxRaadsel.Text = "";
            MessageBox.Show("Begin speler 1. Geef een woord van maximal 14 letters en klik op Start");
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control b in gb.Controls)
                    {
                        if (b is Button)
                        {
                            b.Enabled = true;
                        }
                    }
                }
            }

        }
        private void checkLetters(char letter)
        {

            int isGevonden = 0;
            int isAllesGeraden = 1;
            for (int i = 0; i < lengteVanTekst; i++)
            {
                if (tekst[i] == letter)
                {
                    isGevonden = 1;
                    StringBuilder sb = new StringBuilder(labelword.Text);
                    sb[(i * 3)] = letter;
                    labelword.Text = sb.ToString();
                }
                if (labelword.Text[i * 3] == '*') isAllesGeraden = 0;

            }
            if (isGevonden == 0) foutieveGeraden();
            if (isAllesGeraden == 1) goedGeraden();

        }
        private void goedGeraden()
        {
            MessageBox.Show("Brawo odgadles wszystko. Wygrywasz!!!");
        }
        private void foutieveGeraden()
        {
            aantalFouten++;
            switch (aantalFouten)
            {
                case 1:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\1.png";
                    break;
                case 2:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\2.png";
                    break;
                case 3:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\3.png";
                    break;
                case 4:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\4.png";
                    break;
                case 5:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\5.png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\6.png";
                    break;
                case 7:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\7.png";
                    break;
                case 8:
                    pictureBox1.ImageLocation = "C:\\Users\\Zdzis\\Desktop\\galgje\\8.png";
                    youLost();
                    break;
            }
        }
        private void youLost()
        {
            timer.Enabled = true;
            timer.Start();
            

            
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;
            checkLetters('W');

        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;
            checkLetters('Q');

        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;
            checkLetters('E');

        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;
            checkLetters('R');

        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;
            checkLetters('T');

        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;
            checkLetters('Y');

        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;
            checkLetters('U');

        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;
            checkLetters('I');

        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;
            checkLetters('O');

        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;
            checkLetters('P');

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            checkLetters('A');

        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;
            checkLetters('S');

        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;
            checkLetters('D');

        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;
            checkLetters('F');

        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;
            checkLetters('G');

        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;
            checkLetters('H');

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;
            checkLetters('J');

        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;
            checkLetters('K');

        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;
            checkLetters('L');

        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;
            checkLetters('Z');

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;
            checkLetters('X');

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;
            checkLetters('C');

        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;
            checkLetters('V');

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;
            checkLetters('B');

        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;
            checkLetters('N');

        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;
            checkLetters('M');

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
                pictureBox1.Visible = false;
            else
            {
                pictureBox1.Visible = true;
                aantalBlinken++;
            }
                if (aantalBlinken == 5)
            {
                timer.Stop();
                timer.Enabled = false;
                pictureBox1.ImageLocation = "";
                startVanSpeeltje();
                
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxCheck.Text == tekst) goedGeraden();
            else foutieveGeraden();
        }
    }
}
