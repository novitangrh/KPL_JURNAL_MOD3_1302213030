using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.angka1 = "";
            this.angka2 = "";
        }

        string angka;
        string angka1;
        string angka2;
        int num1;
        int num2;
        private void button1_Click(object sender, EventArgs e)
        {
            angka = "1";
            this.Insert.Text = this.Insert.Text + angka;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            angka = "2";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            angka = "3";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angka = "4";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            angka = "5";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            angka = "6";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            angka = "7";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            angka = "8";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            angka = "9";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            angka = "0";
            this.Insert.Text = this.Insert.Text + angka;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.angka1 = this.Insert.Text; ;
            this.Insert.Text = "";
            Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.angka2 = this.Insert.Text; ;
            this.Insert.Text = "";
            Refresh();
            num1 = int.Parse(angka1);
            num2 = int.Parse(angka2);

            this.Insert = num1 + num2;

        }
    }
}
