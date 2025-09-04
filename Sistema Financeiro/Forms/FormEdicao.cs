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
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Financeiro
{
    public partial class FormEdicao : Form
    {
        public int _id;
        private string _status;
        public int _tipo;

        public FormEdicao(int id, string status, int tipo)
        {

            InitializeComponent();

            // Atribui os valores recebidos aos campos do formulário
            _id = id;
            _status = status;
            _tipo = tipo;
            // Preenche os campos do formulário com os dados
            comboBox1.Text = _status;
        }
        private void AtualizarBanco(int id, string status)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    switch (status)
                    {
                        case "Pago":
                            status = "1";
                            break;
                        case "Não Pago":
                            status = "2";
                            break;
                        case "Agendado":
                            status = "3";
                            break;
                    }
                    string sqlQuery = "UPDATE contasReceber SET statusPagamento = @status WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Executa a query de atualização no banco
                        int resultado = cmd.ExecuteNonQuery();

                        // Verifica se o banco foi atualizado
                        if (resultado > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi atualizada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar os dados:\n" + ex.Message);
            }
        }
        private void AtualizarBanco2(int id, string status)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    switch (status)
                    {
                        case "Pago":
                            status = "1";
                            break;
                        case "Não Pago":
                            status = "2";
                            break;
                        case "Agendado":
                            status = "3";
                            break;
                    }
                    string sqlQuery = "UPDATE contasPagar SET statusPagamento = @status WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Executa a query de atualização no banco
                        int resultado = cmd.ExecuteNonQuery();

                        // Verifica se o banco foi atualizado
                        if (resultado > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi atualizada.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar os dados:\n" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string status = comboBox1.Text;  // Exemplo de controle onde o usuário alterou o nome
            int id = _id;
            int tipo = _tipo;
            if (tipo == 1)
            {
                AtualizarBanco2(id, status);
            }
            else
            {
                AtualizarBanco(id, status);
            }
            this.Close(); // Fecha o formulário após salvar


        }

        private void FormEdicao_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int tipo = _tipo;
            int id = _id;
            if (tipo == 2)
            {
                excluirEntrada(id);
            }
            else
            {
                excluirSaida(id);
            }
        }
        private void excluirEntrada(int id)
        {
                try
            {
            // Conexão com o banco de dados
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                // Comando UPDATE para marcar a exclusão
                string sqlQuery = "UPDATE contasReceber SET data_exclusao = GETDATE() WHERE id = @id";

                // Preparando o comando SQL
                using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                {
                    // Adicionando o parâmetro @id
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executa o comando de atualização
                    int resultado = cmd.ExecuteNonQuery();

                    // Verifica se a atualização foi bem-sucedida
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro marcado como excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao marcar o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    catch (Exception ex)
    {
        MessageBox.Show("Erro ao tentar atualizar o banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
        private void excluirSaida(int id)
        {
            try
            {
                // Conexão com o banco de dados
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    // Comando UPDATE para marcar a exclusão
                    string sqlQuery = "UPDATE contasPagar SET data_exclusao = GETDATE() WHERE id = @id";

                    // Preparando o comando SQL
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        // Adicionando o parâmetro @id
                        cmd.Parameters.AddWithValue("@id", id);

                        // Executa o comando de atualização
                        int resultado = cmd.ExecuteNonQuery();

                        // Verifica se a atualização foi bem-sucedida
                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro marcado como excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Falha ao marcar o registro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar o banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}

