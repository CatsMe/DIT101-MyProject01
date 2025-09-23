using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int myInterval;
            //myInterval = txtInrerval.Text;
            myInterval = Convert.ToInt32(txtInrerval.Text);
            //MessageBox.Show("Convert Complete");

            int guessResult;
            guessResult = rnd.Next(1,7);
            //txtGuessNumber.Text = guessResult.ToString();
            txtGuessNumber.Text = "" + guessResult;

            //picDice.Image = Image.FromFile("D:\\School Space\\DIT101\\Asset\\dice\\3.png");
            picDice.Image = Image.FromFile("D:\\School Space\\DIT101\\Asset\\dice\\" + guessResult + ".png");
        }

        Random rnd;
        private void btnCreateRnd_Click(object sender, EventArgs e)
        {

            rnd = new Random();

            picDice.Image = Image.FromFile("D:\\School Space\\DIT101\\Asset\\dice\\5.png");
        }

        private void picDice_Click(object sender, EventArgs e)
        {

        }
    }
}
