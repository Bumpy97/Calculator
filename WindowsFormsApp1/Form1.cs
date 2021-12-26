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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }


        public float temp1 = 0;
        public float temp2 = 0;

        bool isplus = false;
        private void button10_Click(object sender, EventArgs e) //plus
        {
            temp1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            isplus = true;
        }

        bool isminus = false;
        private void button11_Click(object sender, EventArgs e) //minus
        {
            temp1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            isminus = true;
        }


        bool isdivision = false;
        private void button14_Click(object sender, EventArgs e) // /
        {
            temp1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            isdivision = true;
        }



        bool ismultiply = false;
        private void button12_Click(object sender, EventArgs e) // *
        {
            temp1 = Convert.ToInt32(label1.Text);
            label1.Text = "";
            ismultiply = true;
        }



        public void button13_Click(object sender, EventArgs e) //enter
        {
            if (isplus)
            {
                float end = temp1 + Convert.ToInt32(label1.Text);
                label1.Text = Convert.ToString(end);
                end = 0; temp1 = 0; temp2 = 0;
                isplus = false;
            }
            if (isminus)
            {
                float end = temp1 - Convert.ToInt32(label1.Text);
                label1.Text = Convert.ToString(end);
                end = 0; temp1 = 0; temp2 = 0;
                isminus = false;
            }

            if (isdivision)
            {
                float end = temp1 / Convert.ToInt32(label1.Text);
                label1.Text = Convert.ToString(end);
                end = 0; temp1 = 0; temp2 = 0;
                isdivision = false;
            }

            if (ismultiply)
            {
                float end = temp1 * Convert.ToInt32(label1.Text);
                label1.Text = Convert.ToString(end);
                end = 0; temp1 = 0; temp2 = 0;
                ismultiply = false;
            }
            
        }

        private void button15_Click(object sender, EventArgs e) // CLEAR
        {
            label1.Text = "";
            temp1 = 0;
            temp2 = 0;

        }


    }
}
