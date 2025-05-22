namespace Sistema_Financeiro.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Notificacoes = new System.Windows.Forms.Label();
            this.BemVindoText = new System.Windows.Forms.Label();
            this.notificacoesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Notificacoes
            // 
            this.Notificacoes.AutoSize = true;
            this.Notificacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notificacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificacoes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Notificacoes.Location = new System.Drawing.Point(0, 0);
            this.Notificacoes.Margin = new System.Windows.Forms.Padding(30);
            this.Notificacoes.Name = "Notificacoes";
            this.Notificacoes.Padding = new System.Windows.Forms.Padding(30, 30, 0, 30);
            this.Notificacoes.Size = new System.Drawing.Size(208, 96);
            this.Notificacoes.TabIndex = 7;
            this.Notificacoes.Text = "Notificações";
            // 
            // BemVindoText
            // 
            this.BemVindoText.AutoSize = true;
            this.BemVindoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.BemVindoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.BemVindoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoText.ForeColor = System.Drawing.Color.Gainsboro;
            this.BemVindoText.Location = new System.Drawing.Point(0, 96);
            this.BemVindoText.Name = "BemVindoText";
            this.BemVindoText.Size = new System.Drawing.Size(200, 42);
            this.BemVindoText.TabIndex = 8;
            this.BemVindoText.Text = "Bem Vindo";
            // 
            // notificacoesBox
            // 
            this.notificacoesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.notificacoesBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.notificacoesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificacoesBox.ForeColor = System.Drawing.Color.White;
            this.notificacoesBox.Location = new System.Drawing.Point(0, 138);
            this.notificacoesBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.notificacoesBox.Multiline = true;
            this.notificacoesBox.Name = "notificacoesBox";
            this.notificacoesBox.Size = new System.Drawing.Size(1532, 685);
            this.notificacoesBox.TabIndex = 9;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1532, 672);
            this.Controls.Add(this.notificacoesBox);
            this.Controls.Add(this.BemVindoText);
            this.Controls.Add(this.Notificacoes);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Notificacoes;
        private System.Windows.Forms.Label BemVindoText;
        private System.Windows.Forms.TextBox notificacoesBox;
    }
}