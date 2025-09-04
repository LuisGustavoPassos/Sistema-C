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
            this.panel2.Size = new System.Drawing.Size(1370, 46);
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
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMenu.Size = new System.Drawing.Size(52, 46);
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
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(210, 70);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1160, 669);
            this.DashboardPanel.TabIndex = 1;
            this.DashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panelMenu.Location = new System.Drawing.Point(0, 46);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 693);
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
            this.BtnConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.BtnConfiguracoes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracoes.IconSize = 40;
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(0, 240);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnConfiguracoes.Size = new System.Drawing.Size(209, 60);
            this.BtnConfiguracoes.TabIndex = 7;
            this.BtnConfiguracoes.Text = "Administração";
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
            this.BtnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinanceiro.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnFinanceiro.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnFinanceiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFinanceiro.IconSize = 40;
            this.BtnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFinanceiro.Location = new System.Drawing.Point(0, 180);
            this.BtnFinanceiro.Name = "BtnFinanceiro";
            this.BtnFinanceiro.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnFinanceiro.Size = new System.Drawing.Size(188, 60);
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
            this.BtnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastros.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCadastros.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCadastros.IconSize = 40;
            this.BtnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastros.Location = new System.Drawing.Point(0, 120);
            this.BtnCadastros.Name = "BtnCadastros";
            this.BtnCadastros.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnCadastros.Size = new System.Drawing.Size(188, 60);
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
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashboard.IconSize = 40;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 60);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnDashboard.Size = new System.Drawing.Size(188, 60);
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
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHome.IconSize = 40;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnHome.Size = new System.Drawing.Size(188, 60);
            this.BtnHome.TabIndex = 8;
            this.BtnHome.Text = "Menu";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogOut.IconSize = 40;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 633);
            this.BtnLogOut.MaximumSize = new System.Drawing.Size(188, 60);
            this.BtnLogOut.MinimumSize = new System.Drawing.Size(188, 60);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.BtnLogOut.Size = new System.Drawing.Size(188, 60);
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
            this.panel1.Location = new System.Drawing.Point(188, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 693);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(210, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 24);
            this.panel3.TabIndex = 9;
            // 
            // SistemaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 739);
            this.Controls.Add(this.DashboardPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SistemaFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton BtnConfiguracoes;
        private FontAwesome.Sharp.IconButton BtnFinanceiro;
        private FontAwesome.Sharp.IconButton BtnCadastros;
        private FontAwesome.Sharp.IconButton BtnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton BtnMenu;
        private FontAwesome.Sharp.IconButton BtnLogOut;
    }
}

