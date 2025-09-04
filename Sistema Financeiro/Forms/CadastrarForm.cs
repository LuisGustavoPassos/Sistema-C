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
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
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
            this.Hide(); // Oculta o CadastrosForm
            LoginForm loginForm = new LoginForm(); // Cria uma instância de LoginForm
            loginForm.ShowDialog(); // Exibe o LoginForm como modal
            this.Close(); // Fecha o CadastrosForm após o LoginForm ser fechado
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de senha e confirmar senha são iguais
            if (string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos de senha e confirmar senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o campo usuário não está vazio
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("O campo de usuário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se as senhas coincidirem, chama a procedure para inserir os dados no banco
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("InserirUsuario", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Passa os parâmetros para a procedure
                        cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text); // A senha já foi validada, então pode ser inserida em texto simples. Recomendado usar hashing aqui!

                        // Executa a procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar cadastrar o usuário:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica se a CheckBox está marcada
            if (checkBox1.Checked)
            {
                // Exibe a senha como texto
                txtSenha.PasswordChar = '\0'; // Nenhum caractere de máscara (senha visível)
                txtConfirmarSenha.PasswordChar = '\0'; // Nenhum caractere de máscara (senha visível)
            }
            else
            {
                // Mascarando a senha novamente
                txtSenha.PasswordChar = '*'; // Exibe a senha como asteriscos
                txtConfirmarSenha.PasswordChar = '*'; // Exibe a senha como asteriscos
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpa os campos de texto
            txtUsuario.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();

            // Caso queira também limpar a máscara de senha, caso o usuário tenha ativado algum tipo de visualização:
            txtSenha.PasswordChar = '*'; // Retorna a máscara de senha asterisco, caso tenha sido alterada
            txtConfirmarSenha.PasswordChar = '*'; // Retorna a máscara para o campo "Confirmar Senha"
        }

        private void txtSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
