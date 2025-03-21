using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTESTE
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma instância de Interface2
            Form2 form2 = new Form2();

            // Exibe a Interface2
            form2.Show();

            // Se quiser fechar a Interface1 após abrir a Interface2:
            this.Hide(); // Ou this.Close(); dependendo do seu caso
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("voce clicou no botao");
            
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void Dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
