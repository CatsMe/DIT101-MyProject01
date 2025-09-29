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
            //myInterval = txtInrerval.Text; -- คือตัวที่ไม่สามารถใช้ได้สำหรับภาษา C#
            myInterval = Convert.ToInt32(txtInrerval.Text);
            //MessageBox.Show("Convert Complete"); -- ใช้ตรวจสอบการทำงานด้านบน

            
        }

        Random rnd;
        private void btnCreateRnd_Click(object sender, EventArgs e)
        {

            rnd = new Random();

            picDice.Image = Image.FromFile("D:\\School space\\Asset\\Picture\\CatCircular.jpg");
        }

        private void picDice_Click(object sender, EventArgs e)
        {

        }

        private void tmrRoll_Tick(object sender, EventArgs e)
        {
            int guessResult;
            guessResult = rnd.Next(1, 7);
            //txtGuessNumber.Text = guessResult.ToString(); -- ใช้ได้เหมือนกันกับบรรทัดล่าง
            txtGuessNumber.Text = "" + guessResult;

            picDice.Image = Image.FromFile("D:\\School space\\Asset\\dice\\" + guessResult + ".png");
        }

        private void btnRoll_MouseDown(object sender, MouseEventArgs e)
        {
            //เมื่อกดค้างที่ปุ่มRollจะทำการสุ่มลูกเต๋า
            tmrRoll.Enabled = true;
        }

        private void btnRoll_MouseUp(object sender, MouseEventArgs e)
        {
            //เมื่อปล่อนที่ปุ่มRollจะทำการหยุดสุ่มลูกเต๋า
            tmrRoll.Enabled = false;
        }
    }
}
