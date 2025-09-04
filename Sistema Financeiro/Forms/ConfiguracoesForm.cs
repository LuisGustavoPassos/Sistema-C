using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Financeiro
{
    public partial class ConfiguracoesForm : Form
    {
        public ConfiguracoesForm()
        {
            InitializeComponent();
        }

        private void ConfiguracoesForm_Load(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                string tabelaDestino = "SELECT * FROM listarContasBancarias";
                string palavraFiltro = comboBox4.Text;
                string palavraPesquisa = textBox2.Text;
                consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView1);
            }
        }
        //clas para salvar informacoes no BD
        public static class chamarBD
        {
            public static bool ExecutarComando(string sqlQuery)
            {
                // 🚫 Validação obrigatória: impedir strings nulas, vazias ou sem comandos
                if (string.IsNullOrWhiteSpace(sqlQuery) ||
                    !(sqlQuery.Trim().ToUpper().StartsWith("INSERT") ||
                      sqlQuery.Trim().ToUpper().StartsWith("UPDATE") ||
                      sqlQuery.Trim().ToUpper().StartsWith("DELETE")))
                {
                    MessageBox.Show("A instrução SQL está vazia ou inválida.\nUse apenas comandos INSERT, UPDATE ou DELETE.",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    SqlConnection cn = new SqlConnection(Conn.StrCon);
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(sqlQuery, cn);
                    int resultado = cmd.ExecuteNonQuery();

                    cn.Close();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha foi inserida.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
                    return false;
                }
            }
        }
        
        //class para dar o ConnectDB
        public static class consultaBD
        
        {
            public static void conectar(string sqlQuery, string palavraFiltro, string palavraPesquisa, DataGridView dgv)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        sqlQuery += "";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using(DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dgv.DataSource = dt;
                                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }
        
        //Class para usar o pesquisa
        public static class pesquisaBD
        {
            public static void pesquisarFiltro(string sqlQuery, string palavraFiltro, string palavraPesquisa, DataGridView dgv)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        sqlQuery += $" WHERE [{palavraFiltro}] LIKE '%{palavraPesquisa}%'";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dgv.DataSource = dt;
                                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            }
                        }                    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }

        
        //BANCO - ok

            //connect DB - Contas Bancarias (estou chamando uma View)
            private void Btn_connDb_Click(object sender, EventArgs e)
            {
                string tabelaDestino = "SELECT * FROM listarContasBancarias";
                string palavraFiltro = comboBox4.Text;
                string palavraPesquisa = textBox2.Text;
                consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView1);
            }

            //pesquisa DB - Contas Bancarias (estou chamando uma View)
            private void btn_pesquisa_conta_Click(object sender, EventArgs e)
            {
                string tabelaDestino = "SELECT * FROM listarContasBancarias";
                string palavraFiltro = comboBox4.Text;
                string palavraPesquisa = textBox2.Text;
                pesquisaBD.pesquisarFiltro(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView1);
            }

            //cadastrar novo - conta bancaria
            private void btn_salvar_cad_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(comboBox2.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tabelaDestino = "dbo.contaBancaria";
                string banco = textBox8.Text;
                string agencia = textBox7.Text;
                string conta = textBox6.Text;
                decimal saldo = decimal.Parse(textBox3.Text, NumberStyles.Currency, new CultureInfo("pt-BR"));
                string tipoConta = comboBox2.Text;
                decimal saldoAtual = decimal.Parse(textBox3.Text, NumberStyles.Currency, new CultureInfo("pt-BR"));



            var sqlQuery = $"INSERT INTO {tabelaDestino} " +
                    "(banco, agencia, conta, saldoInicial, tipoConta, saldoAtual)" +
                    $"VALUES ('{banco}','{agencia}','{conta}','{saldo.ToString(CultureInfo.InvariantCulture)}','{tipoConta}', '{saldoAtual.ToString(CultureInfo.InvariantCulture)}')";

            chamarBD.ExecutarComando(sqlQuery);
            }

        //CATEGORIA - ok

            //connect DB - categoria
            private void button5_Click(object sender, EventArgs e)
            {
                string tabelaDestino = "SELECT id as 'ID', tipo as 'Categoria' FROM categoria";
                string palavraFiltro = comboBox1.Text;
                string palavraPesquisa = textBox4.Text;
                consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView2);
            }
        
            //pesquisa - categoria
            private void button7_Click(object sender, EventArgs e)
            {
                string tabelaDestino = "SELECT * FROM categoria";
                string palavraFiltro = comboBox1.Text;
                string palavraPesquisa = textBox4.Text;
                pesquisaBD.pesquisarFiltro(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView2);
            }

            //cadastrar novo - categoria
            private void btn_save_categoria_Click_1(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tabelaDestino = "dbo.categoria";
                string categoria = textBox5.Text;
                var sqlQuery = $"INSERT INTO {tabelaDestino} " +
                    "(tipo)" +
                    $"VALUES ('{categoria}')";

                chamarBD.ExecutarComando(sqlQuery);
            }
        
        //CENTRO DE CUSTO - ok
            //conectar - centro de custo
                private void button8_Click(object sender, EventArgs e)
                {
                    string tabelaDestino = "SELECT id as 'ID', tipo as 'Centro de Custo' FROM centroCusto";
                    string palavraFiltro = comboBox3.Text;
                    string palavraPesquisa = textBox11.Text;
                    consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView3);
                }

            //pesquisar - centro de custo
                private void iconButton1_Click(object sender, EventArgs e)
                {
                string tabelaDestino = "SELECT * FROM centroCusto";
                string palavraFiltro = comboBox3.Text;
                string palavraPesquisa = textBox11.Text;
                pesquisaBD.pesquisarFiltro(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView3);
                }

            //cadastrar novo - centro de custo
                private void btn_salvar_cc_Click(object sender, EventArgs e)
                {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    string tabelaDestino = "dbo.centroCusto";
                    string cc = textBox1.Text;
                    var sqlQuery = $"INSERT INTO {tabelaDestino} " +
                    "(tipo)" +
                    $"VALUES ('{cc}')";

                    chamarBD.ExecutarComando(sqlQuery);
}
        //FUNCAO - ok

            //conectar - funcao
                    private void button11_Click(object sender, EventArgs e)
                    {
                    string tabelaDestino = "SELECT id as 'ID', funcao as 'Função' FROM funcao";
                    string palavraFiltro = comboBox5.Text;
                    string palavraPesquisa = textBox13.Text;
                    consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView4);
                    }   
            //pesquisar - funcao
                    private void button12_Click(object sender, EventArgs e)
                    {
                    string tabelaDestino = "SELECT * FROM funcao";
                    string palavraFiltro = comboBox5.Text;
                    string palavraPesquisa = textBox13.Text;
                    pesquisaBD.pesquisarFiltro(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView4);
                    }

            //cadastrar novo - funcao
                private void btn_save_funcao_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrWhiteSpace(text_funcao.Text))
                    {
                        MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tabelaDestino = "dbo.funcao";
                    string funcao = text_funcao.Text;
                    var sqlQuery = $"INSERT INTO {tabelaDestino} " +
                        "(funcao)" +
                        $"VALUES ('{funcao}')";

                    chamarBD.ExecutarComando(sqlQuery);
                }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl2.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                            string tabelaDestino = "SELECT * FROM listarContasBancarias";
                            string palavraFiltro = comboBox4.Text;
                            string palavraPesquisa = textBox2.Text;
                            consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView1);                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }

        private void tabControl4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl4.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string tabelaDestino = "SELECT id as 'ID', tipo as 'Categoria' FROM categoria";
                        string palavraFiltro = comboBox1.Text;
                        string palavraPesquisa = textBox4.Text;
                        consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }

        private void tabControl5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl5.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string tabelaDestino = "SELECT id as 'ID', tipo as 'Centro de Custo' FROM centroCusto";
                        string palavraFiltro = comboBox3.Text;
                        string palavraPesquisa = textBox11.Text;
                        consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView3);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }

        private void tabControl6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl6.SelectedIndex == 1)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        string tabelaDestino = "SELECT id as 'ID', funcao as 'Função' FROM funcao";
                        string palavraFiltro = comboBox5.Text;
                        string palavraPesquisa = textBox13.Text;
                        consultaBD.conectar(tabelaDestino, palavraFiltro, palavraPesquisa, dataGridView4);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void tabPage16_Click(object sender, EventArgs e)
        {

        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void btn_limpar_cad_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox3.Text = "";
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisaCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT tipo FROM categoria WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox12.Text);



                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maskedTextBox3.Text = reader["tipo"].ToString();
                    maskedTextBox4.Text = reader["tipo"].ToString();
                }

                else
            {
                    MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                }

                cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE categoria SET tipo = @tipo WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox12.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@tipo", maskedTextBox4.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT tipo FROM centroCusto WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox14.Text);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maskedTextBox5.Text = reader["tipo"].ToString();
                    maskedTextBox6.Text = reader["tipo"].ToString();
                }

                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                }

                cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE centroCusto SET tipo = @tipo WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox14.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@tipo", maskedTextBox6.Text);

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

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT banco, agencia, conta, saldoInicial, tipoConta FROM contaBancaria WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox20.Text);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maskedTextBox1.Text = reader["banco"].ToString();
                    maskedTextBox2.Text = reader["banco"].ToString();

                    textBox18.Text = reader["agencia"].ToString();
                    textBox24.Text = reader["agencia"].ToString();

                    textBox17.Text = reader["conta"].ToString();
                    textBox19.Text = reader["conta"].ToString();

                    textBox16.Text = reader["saldoInicial"].ToString();
                    textBox21.Text = reader["saldoInicial"].ToString();

                    textBox22.Text = reader["tipoConta"].ToString();
                    comboBox6.Text = reader["tipoConta"].ToString();

                }

                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                }

                cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE contaBancaria SET banco = @banco, agencia = @agencia, conta = @conta, saldoInicial = @saldoInicial, tipoConta = @tipoConta WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox20.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }
                        decimal saldo = decimal.Parse(textBox16.Text, NumberStyles.Currency, new CultureInfo("pt-BR"));

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@banco", maskedTextBox1.Text);
                        cmd.Parameters.AddWithValue("@agencia", textBox18.Text);
                        cmd.Parameters.AddWithValue("@conta", textBox17.Text);
                        cmd.Parameters.AddWithValue("@saldoInicial", saldo.ToString(CultureInfo.InvariantCulture));
                        cmd.Parameters.AddWithValue("@tipoConta", comboBox6.Text);


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

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conn.StrCon);
                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT funcao FROM funcao WHERE id = @id", cn);
                cmd.Parameters.AddWithValue("@id", textBox15.Text);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    maskedTextBox7.Text = reader["funcao"].ToString();
                    maskedTextBox8.Text = reader["funcao"].ToString();
                }

                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o ID informado.");
                }

                cn.Close(); // boa prática: fechar mesmo que o GC vá cuidar disso depois

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar ou salvar\n\n" + ex.Message);
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE funcao SET funcao = @funcao WHERE id = @id", cn))
                    {
                        // Validação do ID
                        if (!int.TryParse(textBox15.Text, out int id))
                        {
                            MessageBox.Show("ID inválido.");
                            return;
                        }

                        // Define os parâmetros com os valores dos campos
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@funcao", maskedTextBox8.Text);

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

        private void button4_Click(object sender, EventArgs e)
        {
            text_funcao.Text = "";
        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ConfiguracoesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          ForeColor=Color.Black;
        }
    }
}

