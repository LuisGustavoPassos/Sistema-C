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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaFinanceiro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new FontAwesome.Sharp.IconButton();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.notificacoesBox = new System.Windows.Forms.TextBox();
            this.BemVindoText = new System.Windows.Forms.Label();
            this.Notificacoes = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.BtnFinanceiro = new FontAwesome.Sharp.IconButton();
            this.BtnCadastros = new FontAwesome.Sharp.IconButton();
            this.BtnDashboard = new FontAwesome.Sharp.IconButton();
            this.BtnHome = new FontAwesome.Sharp.IconButton();
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1880, 57);
            this.panel2.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMenu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.BtnMenu.IconColor = System.Drawing.Color.White;
            this.BtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu.IconSize = 40;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMenu.Size = new System.Drawing.Size(70, 57);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.AutoScroll = true;
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.DashboardPanel.Controls.Add(this.notificacoesBox);
            this.DashboardPanel.Controls.Add(this.BemVindoText);
            this.DashboardPanel.Controls.Add(this.Notificacoes);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(280, 87);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1600, 823);
            this.DashboardPanel.TabIndex = 1;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // notificacoesBox
            // 
            this.notificacoesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.notificacoesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificacoesBox.ForeColor = System.Drawing.Color.White;
            this.notificacoesBox.Location = new System.Drawing.Point(0, 138);
            this.notificacoesBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.notificacoesBox.Multiline = true;
            this.notificacoesBox.Name = "notificacoesBox";
            this.notificacoesBox.Size = new System.Drawing.Size(1600, 685);
            this.notificacoesBox.TabIndex = 5;
            this.notificacoesBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BemVindoText
            // 
            this.BemVindoText.AutoSize = true;
            this.BemVindoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.BemVindoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoText.ForeColor = System.Drawing.Color.Gainsboro;
            this.BemVindoText.Location = new System.Drawing.Point(0, 96);
            this.BemVindoText.Name = "BemVindoText";
            this.BemVindoText.Size = new System.Drawing.Size(200, 42);
            this.BemVindoText.TabIndex = 4;
            this.BemVindoText.Text = "Bem Vindo";
            this.BemVindoText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Notificacoes
            // 
            this.Notificacoes.AutoSize = true;
            this.Notificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificacoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Notificacoes.Location = new System.Drawing.Point(0, 0);
            this.Notificacoes.Margin = new System.Windows.Forms.Padding(30);
            this.Notificacoes.Name = "Notificacoes";
            this.Notificacoes.Padding = new System.Windows.Forms.Padding(30, 30, 0, 30);
            this.Notificacoes.Size = new System.Drawing.Size(208, 96);
            this.Notificacoes.TabIndex = 6;
            this.Notificacoes.Text = "Notificações";
            this.Notificacoes.Click += new System.EventHandler(this.Notificacoes_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMenu.Controls.Add(this.BtnConfiguracoes);
            this.panelMenu.Controls.Add(this.BtnFinanceiro);
            this.panelMenu.Controls.Add(this.BtnCadastros);
            this.panelMenu.Controls.Add(this.BtnDashboard);
            this.panelMenu.Controls.Add(this.BtnHome);
            this.panelMenu.Controls.Add(this.BtnLogOut);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 57);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 853);
            this.panelMenu.TabIndex = 8;
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfiguracoes.AutoSize = true;
            this.BtnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.BtnConfiguracoes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracoes.IconSize = 40;
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(0, 296);
            this.BtnConfiguracoes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnConfiguracoes.Size = new System.Drawing.Size(250, 74);
            this.BtnConfiguracoes.TabIndex = 7;
            this.BtnConfiguracoes.Text = "Configuração";
            this.BtnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracoes.UseVisualStyleBackColor = true;
            this.BtnConfiguracoes.Click += new System.EventHandler(this.BtnConfiguracoes_Click);
            // 
            // BtnFinanceiro
            // 
            this.BtnFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinanceiro.AutoSize = true;
            this.BtnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinanceiro.FlatAppearance.BorderSize = 0;
            this.BtnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinanceiro.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnFinanceiro.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFinanceiro.IconSize = 40;
            this.BtnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.Location = new System.Drawing.Point(0, 222);
            this.BtnFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFinanceiro.Name = "BtnFinanceiro";
            this.BtnFinanceiro.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnFinanceiro.Size = new System.Drawing.Size(250, 74);
            this.BtnFinanceiro.TabIndex = 5;
            this.BtnFinanceiro.Text = "Financeiro";
            this.BtnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFinanceiro.UseVisualStyleBackColor = true;
            this.BtnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);
            // 
            // BtnCadastros
            // 
            this.BtnCadastros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastros.AutoSize = true;
            this.BtnCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastros.FlatAppearance.BorderSize = 0;
            this.BtnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastros.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCadastros.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCadastros.IconSize = 40;
            this.BtnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.Location = new System.Drawing.Point(0, 148);
            this.BtnCadastros.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnCadastros.Size = new System.Drawing.Size(250, 74);
            this.BtnCadastros.TabIndex = 2;
            this.BtnCadastros.Text = "Cadastros";
            this.BtnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCadastros.UseVisualStyleBackColor = true;
            this.BtnCadastros.Click += new System.EventHandler(this.BtnCadastros_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.IconSize = 40;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 74);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(250, 74);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHome.AutoSize = true;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.IconSize = 40;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnHome.Size = new System.Drawing.Size(250, 74);
            this.BtnHome.TabIndex = 8;
            this.BtnHome.Text = "Menu";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogOut.AutoSize = true;
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogOut.IconSize = 40;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 779);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnLogOut.Size = new System.Drawing.Size(246, 74);
            this.BtnLogOut.TabIndex = 6;
            this.BtnLogOut.Text = " Account";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(250, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 853);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(280, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 30);
            this.panel3.TabIndex = 9;
            // 
            // SistemaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 910);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SistemaFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton BtnMenu;
        private System.Windows.Forms.Label BemVindoText;
        private System.Windows.Forms.TextBox notificacoesBox;
        private System.Windows.Forms.Label Notificacoes;
    }
}

