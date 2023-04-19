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
    public partial class calculator : Form
    {
        public int Punto { get; private set ; } = 0;
        public int Mas { get; private set; } = 0;

        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Exit(object sender, EventArgs e)
        {
            // Exit the program
            // Using Exit() method
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (Punto == 1) {
            }
            else { 
                this.textBox1.Text = this.textBox1.Text + ".";
                Punto = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] numeros = textBox1.Text.Split('+');
            int a = Int32.Parse(numeros[0]);
            int b = Int32.Parse(numeros[1]);
            textBox1.Text = (a + b).ToString();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Mas == 1)
            {
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "+";
                Mas = 1;
                Punto = 0;
            }
        }
    }
}
