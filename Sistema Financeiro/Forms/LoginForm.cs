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

namespace Sistema_Financeiro.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entre em contato com a administração do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de usuário e senha estão preenchidos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexão com o banco de dados e validação do usuário e senha
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                try
                {
                    cn.Open();

                    // Consulta SQL para verificar se o usuário e senha estão corretos
                    string query = "SELECT TOP 1 [Id], [Usuario], [Senha], [Tipo] FROM [usuarios] WHERE [Usuario] = @usuario AND [Senha] = @senha";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        // Parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        // Verifica se algum registro foi encontrado
                        if (reader.Read())
                        {
                            string tipo = reader["Tipo"].ToString();

                            // Exibe uma mensagem de boas-vindas
                            MessageBox.Show($"Bem-vindo ao sistema!", "Login Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redireciona para o FormMenu ou outro formulário desejado
                            this.Hide(); // Fecha o LoginForm
                            SistemaFinanceiro menu = new SistemaFinanceiro(); // Cria a instância do formulário de menu
                            menu.ShowDialog(); // Exibe o FormMenu
                            this.Close(); // Fecha o LoginForm após o FormMenu ser fechado
                        }
                        else
                        {
                            // Se o usuário não for encontrado ou a senha estiver errada
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar conectar ao banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a CheckBox está marcada
            if (checkBox1.Checked)
            {
                // Exibe a senha como texto
                txtSenha.PasswordChar = '\0'; // Nenhum caractere de máscara (senha visível)
            }
            else
            {
                // Mascarando a senha novamente
                txtSenha.PasswordChar = '*'; // Exibe a senha como asteriscos
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta o LoginForm
            CadastrarForm cadastrarForm = new CadastrarForm(); // Cria uma instância de CadastrosForm
            cadastrarForm.ShowDialog(); // Exibe o CadastrosForm de forma modal
            this.Close(); // Fecha o LoginForm depois que o CadastrosForm for fechado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpa os campos de texto
            txtUsuario.Clear();
            txtSenha.Clear();
            // Caso queira também limpar a máscara de senha, caso o usuário tenha ativado algum tipo de visualização:
            txtSenha.PasswordChar = '*'; // Retorna a máscara de senha asterisco, caso tenha sido alterada
        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
}
