using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class FinanceiroForm : Form
    {
        public FinanceiroForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // Impede loop ao reescrever o texto
            string texto = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(texto))
            {
                txt.Text = "R$ 0,00";
                txt.SelectionStart = txt.Text.Length;
                return;
            }

            // Converte para decimal
            decimal valor = decimal.Parse(texto) / 100;

            // Atualiza com formatação R$ e mantém cursor no fim
            txt.Text = valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
            txt.SelectionStart = txt.Text.Length;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // Impede loop ao reescrever o texto
            string texto = new string(txt.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(texto))
            {
                txt.Text = "R$ 0,00";
                txt.SelectionStart = txt.Text.Length;
                return;
            }

            // Converte para decimal
            decimal valor = decimal.Parse(texto) / 100;

            // Atualiza com formatação R$ e mantém cursor no fim
            txt.Text = valor.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
            txt.SelectionStart = txt.Text.Length;
        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}