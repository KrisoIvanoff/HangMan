using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besenitsa
{
    public partial class Form1 : Form
    {
        string guess = "";
        public void CheckIfLetterIsPresent(char a)
        {
            guess = "";
            List<char> wordRN = new();
            if (chosenWord.Contains(a))
            {
                word.Text = "";
                for (int i = 0; i < wordToChar.Count; i++)
                {
                    if (wordToChar[i] == a)
                    {
                        duma[i] = a;
                    }
                }
                for (int i = 0; i < duma.Count; i++)
                {
                    word.Text += duma[i];
                    word.Text += " ";
                    wordRN.Add(duma[i]);
                }
            }
            else
            {
                UpdateImage();
            }
            for (int i = 0; i < wordRN.Count; i++)
            {
                guess += wordRN[i];
                if (guess.Contains(' '))
                {
                    guess.Remove(' ');
                }
            }
            if (guess == chosenWord)
            {
                MessageBox.Show("Congrats!");
                MakeThingsInActive();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        string[] words = { "CAR", "HOUSE", "PATH", "ACTIVATE", "RETIREMENT", "SENTENCE", "DEVELOP", "MONEY","SENIOR","DEPARTURE", "SITE", "HARDWARE", "RATIONAL","EXPECT", "WOUND", "EXCLUDE", "WAITER","NAIL", "LIFT"};
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            MakeThingsInActive();

        }
        string chosenWord = "";
        List<char> wordToChar = new();
        private void startgameBtn_Click(object sender, EventArgs e)
        {
            duma.Clear();
            counter = 1;    
            pictureBox1.Image = null;
            MakeThingsActive();
            word.Text = String.Empty;
            int arrNum = rnd.Next(0, words.Length);
            chosenWord = words[arrNum];
            label3.Text = arrNum.ToString();
            wordToChar = chosenWord.ToCharArray().ToList();
            label1.Text = chosenWord;
            foreach (var item in chosenWord)
            {
                word.Text += "_ ";
                duma.Add('_');

            }
        }
        List<char> duma = new();

        private void aLbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('A');
            aLbl.Enabled = false;
        }
        private void blbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('B');
            blbl.Enabled = false;
        }

        private void clbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('C');
            clbl.Enabled = false;
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('D');
            dbtn.Enabled = false;
        }

        private void ebtn_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('E');
            ebtn.Enabled = false;
        }

        private void fbtn_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('F');
            fbtn.Enabled = false;
        }

        private void glbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('G');
            glbl.Enabled = false;
        }

        private void hbtn_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('H');
            hbtn.Enabled = false;
        }

        private void ilbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('I');
            ilbl.Enabled = false;
        }

        private void jlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('J');
            jlbl.Enabled = false;
        }

        private void klbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('K');
            klbl.Enabled = false;
        }

        private void llbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('L');
            llbl.Enabled = false;
        }

        private void mlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('M');
            mlbl.Enabled = false;

        }

        private void nlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('N');
            nlbl.Enabled = false;
        }

        private void olbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('O');
            olbl.Enabled = false;
        }

        private void plbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('P');
            plbl.Enabled = false;
        }

        private void qlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('Q');
            qlbl.Enabled = false;
        }

        private void rlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('R');
            rlbl.Enabled = false;
        }
       

        private void slbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('S');
            slbl.Enabled = false;
        }

        private void tlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('T');
            tlbl.Enabled = false;
        }

        private void ulbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('U');
            ulbl.Enabled = false;
        }

        private void vlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('V');
            vlbl.Enabled = false;
        }

        private void wlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('W');
            wlbl.Enabled = false;
        }

        private void xlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('X');
            xlbl.Enabled = false;
        }

        private void ylbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('Y');
            ylbl.Enabled = false;
        }

        private void zlbl_Click(object sender, EventArgs e)
        {
            CheckIfLetterIsPresent('Z');
            zlbl.Enabled = false;

        }
        public void MakeThingsActive()
        {
            aLbl.Enabled = true;
            blbl.Enabled = true;
            clbl.Enabled = true;
            dbtn.Enabled = true;
            ebtn.Enabled = true;
            fbtn.Enabled = true;
            glbl.Enabled = true;
            hbtn.Enabled = true;
            ilbl.Enabled = true;
            jlbl.Enabled = true;
            klbl.Enabled = true;
            mlbl.Enabled = true;
            nlbl.Enabled = true;
            olbl.Enabled = true;
            plbl.Enabled = true;
            qlbl.Enabled = true;
            rlbl.Enabled = true;
            slbl.Enabled = true;
            tlbl.Enabled = true;
            ulbl.Enabled = true;
            vlbl.Enabled = true;
            xlbl.Enabled = true;
            ylbl.Enabled = true;
            zlbl.Enabled = true;
            llbl.Enabled = true;
            wlbl.Enabled = true;
        }
        public void MakeThingsInActive()
        {
            aLbl.Enabled = false;
            blbl.Enabled = false;
            clbl.Enabled = false;
            dbtn.Enabled = false;
            ebtn.Enabled = false;
            fbtn.Enabled = false;
            glbl.Enabled = false;
            hbtn.Enabled = false;
            ilbl.Enabled = false;
            jlbl.Enabled = false;
            klbl.Enabled = false;
            mlbl.Enabled = false;
            nlbl.Enabled = false;
            olbl.Enabled = false;
            plbl.Enabled = false;
            qlbl.Enabled = false;
            rlbl.Enabled = false;
            slbl.Enabled = false;
            tlbl.Enabled = false;
            ulbl.Enabled = false;
            vlbl.Enabled = false;
            wlbl.Enabled = false;
            xlbl.Enabled = false;
            ylbl.Enabled = false;
            zlbl.Enabled = false;
            llbl.Enabled = false;
        }
        int counter = 1;
        private void UpdateImage()
        {
            if (counter == 1)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman1;
            }
            if (counter == 2)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman2;
            }
            if (counter == 3)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman3;
            }
            if (counter == 4)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman4;
            }
            if (counter == 5)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman5;
            }
            if (counter == 6)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman6;
            }
            if (counter == 7)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman7;
            }
            if (counter == 8)
            {
                pictureBox1.Image = Besenitsa.Properties.Resources.hangman8;
                MessageBox.Show("Sad", "You lost!");
                MakeThingsInActive();
            }
            if (word.Text != chosenWord)
            {
                counter++;
            }
        }
    }

}