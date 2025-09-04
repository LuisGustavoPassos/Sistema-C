using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex == 2)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sqlQuery = $"SELECT * FROM VW_cadastros";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message,"Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE cadastro SET registro = @registro, nome = @nome, uf = @uf, cidade = @cidade, telefone = @telefone, email = @email, registroUF = @registroUF WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox1.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@registro", maskedTextBox1.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@nome", textBox14.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@uf", comboBox3.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@cidade", textBox11.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@telefone", textBox10.Text);
                        cmd.Parameters.AddWithValue("@email", textBox9.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@registroUF", textBox13.Text.ToUpper());

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o ID existe.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar os dados:\n\n" + ex.Message);
            }
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
            try
            {

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string palavraFiltro = comboBox4.Text;
                    string palavraPesquisa = textBox2.Text;

                    switch (palavraFiltro)
                    {
                        case "CPF":
                        case "CNPJ":
                            palavraFiltro = "REGISTRO";
                            break;
                        case "Razão Social":
                            palavraFiltro = "NOME";
                            break;
                        case "Inscrição Estadual":
                        case "Registro Geral":
                            palavraFiltro = "[I.E / RG]";
                            break;
                        case "E-mail":
                            palavraFiltro = "[E-MAIL]";
                            break;
                        default:
                            palavraFiltro = comboBox4.Text;
                            break;
                    }

                    if (palavraFiltro != "" && palavraPesquisa != "")
                    {
                        var sqlQuery = $"SELECT * FROM VW_cadastros WHERE {palavraFiltro} LIKE @palavraPesquisa";

                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                        {
                            cmd.Parameters.AddWithValue("@palavraPesquisa", $"%{palavraPesquisa}%");

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    da.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar cadastro:\n\n" + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            
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
                bool valorRadio = true;

                if ((radioButton2.Checked == false) && (radioButton1.Checked == false))
                {
                    valorRadio = false;
                }

                int valorRegistro = 0;

                if (radioButton1.Checked)
                {
                    valorRegistro = 11;
                } else if (radioButton2.Checked)
                {
                    valorRegistro = 14;
                }

                if ((text_registro.Text.Length != valorRegistro) || string.IsNullOrWhiteSpace(text_nome.Text) ||
                    string.IsNullOrWhiteSpace(text_UF.Text) || string.IsNullOrWhiteSpace(text_cidade.Text) ||
                    string.IsNullOrWhiteSpace(text_email.Text) || string.IsNullOrWhiteSpace(text_registroEstadual.Text) || valorRadio == false)
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string sqlQuery = @"
                INSERT INTO cadastro 
                    (registro, nome, uf, cidade, telefone, email, registroUF, tipoRegistro, tipoCadastro, statusAtividade)
                VALUES 
                    (@registro, @nome, @uf, @cidade, @telefone, @email, @registroUF, @tipoRegistro, @tipoCadastro, 1)";

                    
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@registro", text_registro.Text);
                        cmd.Parameters.AddWithValue("@nome", text_nome.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@uf", text_UF.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@cidade", text_cidade.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@telefone", text_telefone.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@email", text_email.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@registroUF", text_registroEstadual.Text.ToUpper());

                        int tipoRegistro = 0;
                        int tipoCadastro = 0;

                        switch (comboBox1.Text)
                        {
                            case "Cliente":
                                tipoCadastro = 1;
                                break;
                            case "Prestador de Serviço":
                                tipoCadastro = 3;
                                break;
                            case "Fornecedor":
                                tipoCadastro = 2;
                                break;
                            default:
                                tipoCadastro = 0;
                                break;
                        }

                        if (radioButton1.Checked)
                        {
                            tipoRegistro = 1;
                        } else if (radioButton2.Checked)
                        {
                            tipoRegistro = 2;
                        }

                            cmd.Parameters.AddWithValue("@tipoRegistro", tipoRegistro);
                        cmd.Parameters.AddWithValue("@tipoCadastro", tipoCadastro);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi inserida.");
                        }
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            comboBox3.SelectedIndex = -1;
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
        }

        private void btn_pesquisaCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT registro, nome, uf, cidade, telefone, email, registroUF, statusAtividade, tipoRegistro FROM cadastro WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);



                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maskedTextBox2.Text = reader["registro"].ToString();
                    maskedTextBox1.Text = reader["registro"].ToString();
                    textBox3.Text = reader["nome"].ToString();
                    textBox14.Text = reader["nome"].ToString();
                    textBox4.Text = reader["registroUF"].ToString();
                    textBox13.Text = reader["registroUF"].ToString();
                    textBox5.Text = reader["uf"].ToString();
                    comboBox3.Text = reader["uf"].ToString();
                    textBox11.Text = reader["cidade"].ToString();
                    textBox6.Text = reader["cidade"].ToString();
                    textBox10.Text = reader["telefone"].ToString();
                    textBox7.Text = reader["telefone"].ToString();
                    textBox8.Text = reader["email"].ToString();
                    textBox9.Text = reader["email"].ToString();
                    int status = Convert.ToInt32(reader["statusAtividade"]);
                    textBox12.Text = status == 1 ? "Ativo" : "Inativo";
                    int tipoRegistro = Convert.ToInt32(reader["tipoRegistro"]);
                    textBox15.Text = tipoRegistro == 1 ? "Pessoa Física" : "Pessoa Jurídica";
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                }

                cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois

                if(textBox15.Text == "Pessoa Física")
                {
                    maskedTextBox1.Mask = "000,000,000-00";
                    maskedTextBox2.Mask = "000,000,000-00";
                    label14.Text = "CPF";
                    label27.Text = "CPF";
                    label15.Text = "Nome";
                    label26.Text = "Nome";
                    label20.Text = "R.G.";
                    label21.Text = "R.G.";
                } else if (textBox15.Text == "Pessoa Jurídica")
                {
                    maskedTextBox1.Mask = "00,000,000/0000-00";
                    maskedTextBox2.Mask = "00,000,000/0000-00";
                    label14.Text = "CNPJ";
                    label27.Text = "CNPJ";
                    label15.Text = "Razão Social";
                    label26.Text = "Razão Social";
                    label20.Text = "I.E.";
                    label21.Text = "I.E.";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE cadastro SET statusAtividade = @statusAtividade WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox1.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        if (textBox12.Text == "Ativo")
                        {
                            cmd.Parameters.AddWithValue("@statusAtividade", 2);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@statusAtividade", 1);
                        }


                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o ID existe.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar os dados:\n\n" + ex.Message);
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


