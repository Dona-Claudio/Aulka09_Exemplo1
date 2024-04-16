using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aulka09_Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (e.KeyChar == 13) {
                maskedTextBox2.Focus;*/
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                maskedTextBox2.Focus();
            }
    }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1 == null) {
                MessageBox.Show("campo vazio");
            }
            else  {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(maskedTextBox2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (listBox3.SelectedIndex == 0)
                textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 1)
                textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            else if (listBox3.SelectedIndex == 2)
                textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            else
                MessageBox.Show("Selecionar um canditato");

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1 == null) {
                MessageBox.Show("campo não pode ser vazio");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("campo vazio");
            }
            else if (maskedTextBox2.Text == "") {
                MessageBox.Show("campo vazio");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(maskedTextBox2.Text);
            }

        }
    }
}
