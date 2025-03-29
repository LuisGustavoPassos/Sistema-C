namespace Sistema_Financeiro
{
    partial class SistemaFinanceiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.BtnFinanceiro = new FontAwesome.Sharp.IconButton();
            this.BtnEstoque = new FontAwesome.Sharp.IconButton();
            this.BtnProdutos = new FontAwesome.Sharp.IconButton();
            this.BtnCadastros = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.BtnConfiguracoes);
            this.panelMenu.Controls.Add(this.BtnLogOut);
            this.panelMenu.Controls.Add(this.BtnFinanceiro);
            this.panelMenu.Controls.Add(this.BtnEstoque);
            this.panelMenu.Controls.Add(this.BtnProdutos);
            this.panelMenu.Controls.Add(this.BtnCadastros);
            this.panelMenu.Controls.Add(this.BtnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 777);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.BtnConfiguracoes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracoes.IconSize = 32;
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(0, 542);
            this.BtnConfiguracoes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnConfiguracoes.Size = new System.Drawing.Size(293, 74);
            this.BtnConfiguracoes.TabIndex = 7;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracoes.UseVisualStyleBackColor = true;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.BtnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogOut.IconSize = 32;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 703);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnLogOut.Size = new System.Drawing.Size(293, 74);
            this.BtnLogOut.TabIndex = 6;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // BtnFinanceiro
            // 
            this.BtnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFinanceiro.FlatAppearance.BorderSize = 0;
            this.BtnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanceiro.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnFinanceiro.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFinanceiro.IconSize = 32;
            this.BtnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.Location = new System.Drawing.Point(0, 468);
            this.BtnFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFinanceiro.Name = "BtnFinanceiro";
            this.BtnFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnFinanceiro.Size = new System.Drawing.Size(293, 74);
            this.BtnFinanceiro.TabIndex = 5;
            this.BtnFinanceiro.Text = "Financeiro";
            this.BtnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFinanceiro.UseVisualStyleBackColor = true;
            this.BtnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // BtnEstoque
            // 
            this.BtnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstoque.FlatAppearance.BorderSize = 0;
            this.BtnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstoque.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEstoque.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.BtnEstoque.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEstoque.IconSize = 32;
            this.BtnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstoque.Location = new System.Drawing.Point(0, 394);
            this.BtnEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEstoque.Name = "BtnEstoque";
            this.BtnEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnEstoque.Size = new System.Drawing.Size(293, 74);
            this.BtnEstoque.TabIndex = 4;
            this.BtnEstoque.Text = "Estoque";
            this.BtnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEstoque.UseVisualStyleBackColor = true;
            this.BtnEstoque.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdutos.FlatAppearance.BorderSize = 0;
            this.BtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdutos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.BtnProdutos.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnProdutos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProdutos.IconSize = 32;
            this.BtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.Location = new System.Drawing.Point(0, 320);
            this.BtnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProdutos.Size = new System.Drawing.Size(293, 74);
            this.BtnProdutos.TabIndex = 3;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnCadastros
            // 
            this.BtnCadastros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastros.FlatAppearance.BorderSize = 0;
            this.BtnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCadastros.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCadastros.IconSize = 32;
            this.BtnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.Location = new System.Drawing.Point(0, 246);
            this.BtnCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCadastros.Size = new System.Drawing.Size(293, 74);
            this.BtnCadastros.TabIndex = 2;
            this.BtnCadastros.Text = "Cadastros";
            this.BtnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastros.UseVisualStyleBackColor = true;
            this.BtnCadastros.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.IconSize = 32;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 172);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(293, 74);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 172);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // SistemaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 777);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaFinanceiro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnLogOut;
        private FontAwesome.Sharp.IconButton BtnFinanceiro;
        private FontAwesome.Sharp.IconButton BtnEstoque;
        private FontAwesome.Sharp.IconButton BtnProdutos;
        private FontAwesome.Sharp.IconButton BtnCadastros;
        private FontAwesome.Sharp.IconButton BtnConfiguracoes;
    }
}

