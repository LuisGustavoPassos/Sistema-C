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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Sistema_Financeiro
{
    public partial class FinanceiroForm : Form
    {
        public FinanceiroForm()
        {
            InitializeComponent();
        }
        private void FinanceiroForm_Load(object sender, EventArgs e)
        {

            CarregarCombos();
            CarregarCombos2();
            if (tabControl1.SelectedIndex == 0)
            {
                string tabelaDestino = "SELECT * FROM VW_contaReceber";
                consultaBD.conectar(tabelaDestino, dgv_entrada);
            }
            /* saída
            PreencherCombo("banco", "dbo.contaBancaria", comboBox1);
            PreencherCombo("nome", "dbo.cadastro", comboBox2);
            PreencherCombo("tipo", "dbo.categoria", comboBox3);
            PreencherCombo("tipo", "dbo.centroCusto", comboBox4);

            //entrada
            PreencherCombo("banco", "dbo.contaBancaria", comboBox10);
            PreencherCombo("nome", "dbo.cadastro", comboBox9);
            PreencherCombo("tipo", "dbo.categoria", comboBox8);
            PreencherCombo("tipo", "dbo.centroCusto", comboBox7);*/
        }
        public static class consultaBD

        {
            public static void conectar(string sqlQuery, DataGridView dgv)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        sqlQuery += "";

                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dgv.DataSource = dt;
                                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
        //por enquanto obsoleto
        private void PreencherCombo(string coluna, string tabela, ComboBox cb)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string sqlQuery = $"SELECT {coluna} FROM {tabela}";  // Assumindo que 'coluna' é o nome da coluna a ser exibida

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        DataTable dt = new DataTable(); // Correção aqui: instanciação do DataTable
                        da.Fill(dt);

                        cb.DisplayMember = coluna;  // Exibe o valor da coluna na ComboBox
                        cb.ValueMember = coluna;    // O valor interno será o valor da coluna também
                        cb.DataSource = dt;         // Atribui os dados à ComboBox
                        cb.SelectedIndex = -1;      // Comeca sem nenhum valor atribuido
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados\n" + ex.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*TextBox txt = (TextBox)sender;

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
            txt.SelectionStart = txt.Text.Length;*/
        }
        private void CarregarCombos()
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                // Carregar Devedor (cadastro)
                SqlDataAdapter daDevedor = new SqlDataAdapter("SELECT id, nome FROM cadastro", cn);
                DataTable dtDevedor = new DataTable();
                daDevedor.Fill(dtDevedor);
                comboBox9.DataSource = dtDevedor;
                comboBox9.DisplayMember = "nome";
                comboBox9.ValueMember = "id";
                comboBox9.SelectedIndex = -1;

                // Carregar conta bancaria
                SqlDataAdapter daBanco = new SqlDataAdapter("SELECT id, banco FROM contaBancaria", cn);
                DataTable dtBanco = new DataTable();
                daBanco.Fill(dtBanco);
                comboBox10.DataSource = dtBanco;
                comboBox10.DisplayMember = "banco";
                comboBox10.ValueMember = "id";
                comboBox10.SelectedIndex = -1;

                // Carregar Categoria
                SqlDataAdapter daCategoria = new SqlDataAdapter("SELECT id, tipo FROM categoria", cn);
                DataTable dtCategoria = new DataTable();
                daCategoria.Fill(dtCategoria);
                comboBox8.DataSource = dtCategoria;
                comboBox8.DisplayMember = "tipo";
                comboBox8.ValueMember = "id";
                comboBox8.SelectedIndex = -1;

                // Carregar Centro de Custo
                SqlDataAdapter daCentro = new SqlDataAdapter("SELECT id, tipo FROM centroCusto", cn);
                DataTable dtCentro = new DataTable();
                daCentro.Fill(dtCentro);
                comboBox7.DataSource = dtCentro;
                comboBox7.DisplayMember = "tipo";
                comboBox7.ValueMember = "id";
                comboBox7.SelectedIndex = -1;

                // Carregar Devedor DGV
                SqlDataAdapter dadgvSaida = new SqlDataAdapter("SELECT id, nome FROM cadastro", cn);
                DataTable dtdgvSaida = new DataTable();
                dadgvSaida.Fill(dtdgvSaida);
                comboBox11.DataSource = dtdgvSaida;
                comboBox11.DisplayMember = "nome";
                comboBox11.ValueMember = "id";
                comboBox11.SelectedIndex = -1;


            }
        }
        private void CarregarCombos2()
        {
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();

                // Carregar Credor (cadastro)
                SqlDataAdapter daDevedor = new SqlDataAdapter("SELECT id, nome FROM cadastro", cn);
                DataTable dtDevedor = new DataTable();
                daDevedor.Fill(dtDevedor);
                comboBox2.DataSource = dtDevedor;
                comboBox2.DisplayMember = "nome";
                comboBox2.ValueMember = "id";
                comboBox2.SelectedIndex = -1;

                // Carregar Categoria
                SqlDataAdapter daCategoria = new SqlDataAdapter("SELECT id, tipo FROM categoria", cn);
                DataTable dtCategoria = new DataTable();
                daCategoria.Fill(dtCategoria);
                comboBox3.DataSource = dtCategoria;
                comboBox3.DisplayMember = "tipo";
                comboBox3.ValueMember = "id";
                comboBox3.SelectedIndex = -1;

                // Carregar Centro de Custo
                SqlDataAdapter daCentro = new SqlDataAdapter("SELECT id, tipo FROM centroCusto", cn);
                DataTable dtCentro = new DataTable();
                daCentro.Fill(dtCentro);
                comboBox4.DataSource = dtCentro;
                comboBox4.DisplayMember = "tipo";
                comboBox4.ValueMember = "id";
                comboBox4.SelectedIndex = -1;


                // Carregar Banco
                SqlDataAdapter daBanco = new SqlDataAdapter("SELECT id, banco FROM contaBancaria", cn);
                DataTable dtBanco = new DataTable();
                daBanco.Fill(dtBanco);
                comboBox1.DataSource = dtBanco;
                comboBox1.DisplayMember = "banco";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;

                // Carregar Credor DGV
                SqlDataAdapter dadgvSaida = new SqlDataAdapter("SELECT id, nome FROM cadastro", cn);
                DataTable dtdgvSaida = new DataTable();
                dadgvSaida.Fill(dtdgvSaida);
                comboBox12.DataSource = dtdgvSaida;
                comboBox12.DisplayMember = "nome";
                comboBox12.ValueMember = "id";
                comboBox12.SelectedIndex = -1;
            }
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(comboBox9.Text) || string.IsNullOrWhiteSpace(comboBox8.Text) ||
                    string.IsNullOrWhiteSpace(comboBox10.Text) || string.IsNullOrWhiteSpace(comboBox7.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker2.Text) || string.IsNullOrWhiteSpace(textBox8.Text) ||
                    string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(comboBox6.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte os SelectedValue para int com segurança
                if (!int.TryParse(comboBox9.SelectedValue?.ToString(), out int idDevedor) ||
                    !int.TryParse(comboBox8.SelectedValue?.ToString(), out int idCategoria) ||
                    !int.TryParse(comboBox7.SelectedValue?.ToString(), out int idCentroCusto) ||
                    !int.TryParse(comboBox10.SelectedValue?.ToString(), out int idBanco))
                {
                    MessageBox.Show("Erro ao converter os valores de Devedor, Categoria ou Centro de Custo. Verifique as seleções.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte valor para decimal com segurança
                if (!decimal.TryParse(textBox7.Text, out decimal valor))
                {
                    MessageBox.Show("O valor inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string sqlQuery = @"
                INSERT INTO contasReceber 
                (referencia, devedor, valor, categoria, centroCusto, dataLancamento, dataRecebimento, statusPagamento, banco) 
                VALUES 
                (@referencia, @devedor, @valor, @categoria, @centroCusto, @dataLancamento, @dataRecebimento, @statusPagamento, @banco)";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.Add("@referencia", SqlDbType.VarChar).Value = textBox5.Text;
                        cmd.Parameters.Add("@devedor", SqlDbType.Int).Value = idDevedor;
                        cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
                        cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = idCategoria;
                        cmd.Parameters.Add("@centroCusto", SqlDbType.Int).Value = idCentroCusto;
                        cmd.Parameters.Add("@dataLancamento", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@dataRecebimento", SqlDbType.DateTime).Value = dateTimePicker2.Value;
                        cmd.Parameters.Add("@statusPagamento", SqlDbType.Int).Value = 3; // ou o ID real de status se tiver combo
                        cmd.Parameters.Add("@banco", SqlDbType.Int).Value = idBanco;

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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Text = "";
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Início do SQL
                string sql = @"SELECT * FROM VW_contaReceber WHERE 1=1";

                // Lista de parâmetros e comandos
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Vencimento Inicial e Final
                if (dateTimePicker3.Checked && dateTimePicker4.Checked)
                {
                    sql += " AND [Data Recebimento] BETWEEN @dataInicial AND @dataFinal";
                    parametros.Add(new SqlParameter("@dataInicial", dateTimePicker3.Value.Date));
                    parametros.Add(new SqlParameter("@dataFinal", dateTimePicker4.Value.Date));
                }

                // Credor
                if (!string.IsNullOrWhiteSpace(comboBox11.Text))
                {
                    sql += " AND registro = @registro";
                    parametros.Add(new SqlParameter("@registro", comboBox11.Text));
                }

                // Referência (NF, N° Fatura)
                if (!string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    sql += " AND Referência LIKE @referencia";
                    parametros.Add(new SqlParameter("@referencia", "%" + textBox9.Text + "%"));
                }

                // Executando a consulta
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddRange(parametros.ToArray());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Exibindo os dados no DataGridView (ajuste para o seu controle)
                        dgv_entrada.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar registros:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Início do SQL
                string sql = @"SELECT * FROM VW_contaPagar WHERE 1=1";

                // Lista de parâmetros e comandos
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Vencimento Inicial e Final
                if (dateTimePicker6.Checked && dateTimePicker5.Checked)
                {
                    sql += " AND [Data Pagamento] BETWEEN @dataInicial AND @dataFinal";
                    parametros.Add(new SqlParameter("@dataInicial", dateTimePicker6.Value.Date));
                    parametros.Add(new SqlParameter("@dataFinal", dateTimePicker5.Value.Date));
                }

                // Credor
                if (!string.IsNullOrWhiteSpace(comboBox12.Text))
                {
                    sql += " AND credor = @credor";
                    parametros.Add(new SqlParameter("@credor", comboBox12.Text));
                }

                // Referência (NF, N° Fatura)
                if (!string.IsNullOrWhiteSpace(textBox10.Text))
                {
                    sql += " AND Referência LIKE @referencia";
                    parametros.Add(new SqlParameter("@referencia", "%" + textBox10.Text + "%"));
                }

                // Executando a consulta
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddRange(parametros.ToArray());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Exibindo os dados no DataGridView (ajuste para o seu controle)
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao filtrar registros:\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_entrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos obrigatórios estão preenchidos
                if (string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox3.Text) ||
                    string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox4.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte os SelectedValue para int com segurança
                if (!int.TryParse(comboBox2.SelectedValue?.ToString(), out int idCredor) ||
                    !int.TryParse(comboBox3.SelectedValue?.ToString(), out int idCategoria) ||
                    !int.TryParse(comboBox4.SelectedValue?.ToString(), out int idCentroCusto) ||
                    !int.TryParse(comboBox1.SelectedValue?.ToString(), out int idBanco))
                {
                    MessageBox.Show("Erro ao converter os valores de Credor, Categoria ou Centro de Custo. Verifique as seleções.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Converte valor para decimal com segurança
                if (!decimal.TryParse(textBox2.Text, out decimal valor))
                {
                    MessageBox.Show("O valor inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    string sqlQuery = @"
                INSERT INTO contasPagar 
                (referencia, credor, valor, categoria, centroCusto, dataLancamento, dataPagamento, statusPagamento, banco) 
                VALUES 
                (@referencia, @credor, @valor, @categoria, @centroCusto, @dataLancamento, @dataPagamento, @statusPagamento, @banco)";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                    {
                        cmd.Parameters.Add("@referencia", SqlDbType.VarChar).Value = textBox4.Text;
                        cmd.Parameters.Add("@credor", SqlDbType.Int).Value = idCredor;
                        cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
                        cmd.Parameters.Add("@categoria", SqlDbType.Int).Value = idCategoria;
                        cmd.Parameters.Add("@centroCusto", SqlDbType.Int).Value = idCentroCusto;
                        cmd.Parameters.Add("@dataLancamento", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@dataPagamento", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@statusPagamento", SqlDbType.Int).Value = 3; // ou o ID real de status se tiver combo
                        cmd.Parameters.Add("@banco", SqlDbType.Int).Value = idBanco;

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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            LimparCamposAba(tabPage3);
        }
        private void LimparCamposAba(TabPage aba)
        {
            foreach (Control ctrl in aba.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (ctrl is DateTimePicker dtPicker)
                {
                    dtPicker.Value = DateTime.Now; // ou algum valor padrão
                }
                else if (ctrl.HasChildren)
                {
                    LimparCamposAbaRecursivo(ctrl);
                }
            }
        }

        private void LimparCamposAbaRecursivo(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (ctrl is DateTimePicker dtPicker)
                {
                    dtPicker.Value = DateTime.Now;
                }
                else if (ctrl.HasChildren)
                {
                    LimparCamposAbaRecursivo(ctrl);
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            LimparCamposAba(tabPage5);

        }

        private void dgv_entrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //id 2 = entrada
                // Obtém o ID ou chave primária da linha clicada
                var id = Convert.ToInt32(dgv_entrada.Rows[e.RowIndex].Cells["ID"].Value);

                // Obtém os dados da linha (exemplo: devedor, valor, etc.)
                var status = dgv_entrada.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                var tipo = Convert.ToInt32("2");


            // Chama o formulário de edição e passa os dados
            FormEdicao formEdicao = new FormEdicao(id, status, tipo); // Supondo que esses sejam os dados para editar
                formEdicao.ShowDialog();  // Abre o Form de Edição como uma janela modal
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox12.SelectedIndex = -1;
            textBox10.Text = "";
            string tabelaDestino = "SELECT * FROM VW_contaPagar";
            consultaBD.conectar(tabelaDestino, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox11.SelectedIndex = -1;
            textBox9.Text = "";
            string tabelaDestino = "SELECT * FROM VW_contaReceber";
            consultaBD.conectar(tabelaDestino, dgv_entrada);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtém o ID ou chave primária da linha clicada
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            // Obtém os dados da linha (exemplo: devedor, valor, etc.)
            var status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            var tipo = Convert.ToInt32("1");

            // Chama o formulário de edição e passa os dados
            FormEdicao formEdicao = new FormEdicao(id, status, tipo); // Supondo que esses sejam os dados para editar
            formEdicao.ShowDialog();  // Abre o Form de Edição como uma janela modal

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



    }
