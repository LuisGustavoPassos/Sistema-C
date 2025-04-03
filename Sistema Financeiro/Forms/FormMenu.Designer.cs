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
            System.Windows.Forms.TextBox textBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaFinanceiro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnMenu = new FontAwesome.Sharp.IconButton();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.panelAtualizacoes = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.BtnFinanceiro = new FontAwesome.Sharp.IconButton();
            this.BtnCadastros = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            textBox2 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.panelAtualizacoes.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.BtnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1410, 46);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1185, 37);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Bem vindo";
            // 
            // BtnMenu
            // 
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.BtnMenu.IconColor = System.Drawing.Color.White;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 32;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMenu.Size = new System.Drawing.Size(54, 46);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.DashboardPanel.Controls.Add(this.textBox1);
            this.DashboardPanel.Controls.Add(this.panelAtualizacoes);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(196, 46);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1214, 693);
            this.DashboardPanel.TabIndex = 1;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelAtualizacoes
            // 
            this.panelAtualizacoes.AutoSize = true;
            this.panelAtualizacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panelAtualizacoes.Controls.Add(textBox2);
            this.panelAtualizacoes.Location = new System.Drawing.Point(67, 140);
            this.panelAtualizacoes.Name = "panelAtualizacoes";
            this.panelAtualizacoes.Size = new System.Drawing.Size(1075, 488);
            this.panelAtualizacoes.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.CausesValidation = false;
            textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            textBox2.Enabled = false;
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            textBox2.Location = new System.Drawing.Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(1075, 28);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ultimas Atualizações";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.BtnConfiguracoes);
            this.panelMenu.Controls.Add(this.BtnLogOut);
            this.panelMenu.Controls.Add(this.BtnFinanceiro);
            this.panelMenu.Controls.Add(this.BtnCadastros);
            this.panelMenu.Controls.Add(this.BtnDashboard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(196, 693);
            this.panelMenu.TabIndex = 8;
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.BtnConfiguracoes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracoes.IconSize = 32;
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(0, 180);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnConfiguracoes.Size = new System.Drawing.Size(196, 60);
            this.BtnConfiguracoes.TabIndex = 7;
            this.BtnConfiguracoes.Text = "Configurações";
            this.BtnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracoes.UseVisualStyleBackColor = true;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.BtnConfiguracoes_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.BtnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogOut.IconSize = 32;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 633);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnLogOut.Size = new System.Drawing.Size(196, 60);
            this.BtnLogOut.TabIndex = 6;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnFinanceiro
            // 
            this.BtnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFinanceiro.FlatAppearance.BorderSize = 0;
            this.BtnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanceiro.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnFinanceiro.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFinanceiro.IconSize = 32;
            this.BtnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.Location = new System.Drawing.Point(0, 120);
            this.BtnFinanceiro.Name = "BtnFinanceiro";
            this.BtnFinanceiro.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnFinanceiro.Size = new System.Drawing.Size(196, 60);
            this.BtnFinanceiro.TabIndex = 5;
            this.BtnFinanceiro.Text = "Financeiro";
            this.BtnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFinanceiro.UseVisualStyleBackColor = true;
            this.BtnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // BtnCadastros
            // 
            this.BtnCadastros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastros.FlatAppearance.BorderSize = 0;
            this.BtnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCadastros.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCadastros.IconSize = 32;
            this.BtnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.Location = new System.Drawing.Point(0, 60);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnCadastros.Size = new System.Drawing.Size(196, 60);
            this.BtnCadastros.TabIndex = 2;
            this.BtnCadastros.Text = "Cadastros";
            this.BtnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastros.UseVisualStyleBackColor = true;
            this.BtnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.IconSize = 32;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(196, 60);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // SistemaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 739);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SistemaFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financeiro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.panelAtualizacoes.ResumeLayout(false);
            this.panelAtualizacoes.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnConfiguracoes;
        private FontAwesome.Sharp.IconButton BtnLogOut;
        private FontAwesome.Sharp.IconButton BtnFinanceiro;
        private FontAwesome.Sharp.IconButton BtnCadastros;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private FontAwesome.Sharp.IconButton BtnMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelAtualizacoes;
    }
}

