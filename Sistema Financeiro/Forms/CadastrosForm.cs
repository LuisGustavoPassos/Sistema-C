using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class CadastrosForm : Form
    {
        public CadastrosForm()
        {
            InitializeComponent();
        }

        public string tipoPessoa;

        private void CadastrosForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedIndex = -1;
            text_registro.Text = "";
            text_nome.Text = "";
            text_UF.SelectedIndex = -1;
            text_cidade.Text = "";
            text_telefone.Text = "";
            text_email.Text = "";
            text_registroEstadual.Text = "";
        }

            

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            text_registro.Mask = "000,000,000-00";
            label2.Text = "CPF";
            label3.Text = "Nome";
            label6.Text = "R.G.";
            tipoPessoa = "Pessoa Física";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            text_registro.Mask = "00,000,000/0000-00";
            label2.Text = "CNPJ";
            label3.Text = "Razão Social";
            label6.Text = "I.E.";
            tipoPessoa = "Pessoa Jurídica";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Fornecedor")
            {
                radioButton2.Checked = true;

                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                string palavraFiltro = comboBox4.Text;
                string palavraPesquisa = textBox2.Text;

                var sqlQuery = $"SELECT * FROM fornecedor WHERE {palavraFiltro} = '{palavraPesquisa}'";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string palavraFiltro = comboBox4.Text;
                    string palavraPesquisa = textBox2.Text;

                    var sqlQuery = "SELECT * FROM fornecedor";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    MessageBox.Show("Conectado ao banco de dados","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

private void btn_Cadastrar_Click(object sender, EventArgs e)
{
    try
    {
        SqlConnection cn = new SqlConnection(Conn.StrCon);
        cn.Open();

            string tabelaDestino = "dbo.cadastro";
            string registro = text_registro.Text;
            string nome = text_nome.Text;
            string uf = text_UF.Text;
            string cidade = text_cidade.Text;
            string telefone = text_telefone.Text;
            string email = text_email.Text;
            string registroUF = text_registroEstadual.Text;
            string tipoRegistro = "1";
            string tipoCadastro = "1";
            string statusAtividade = "1";

            var sqlQuery = $"INSERT INTO {tabelaDestino} " +
                           "(registro, nome, uf, cidade, telefone, email, registroUF, tipoRegistro, tipoCadastro, statusAtividade) " +
                           $"VALUES ('{registro}', '{nome}', '{uf}', '{cidade}', '{telefone}', '{email}', '{registroUF}','{tipoRegistro}','{tipoCadastro}','{statusAtividade}')";

            SqlCommand cmd = new SqlCommand(sqlQuery, cn);
            int resultado = cmd.ExecuteNonQuery();

            if (resultado > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                {
                    MessageBox.Show("Nenhuma linha foi inserida.");
                }
                    cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois
                }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }
    }
        private void text_registro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}


