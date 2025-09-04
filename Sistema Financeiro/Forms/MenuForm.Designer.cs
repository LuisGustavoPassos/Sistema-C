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
            this.BemVindoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BemVindoText
            // 
            this.BemVindoText.AutoSize = true;
            this.BemVindoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.BemVindoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.BemVindoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindoText.ForeColor = System.Drawing.Color.Gainsboro;
            this.BemVindoText.Location = new System.Drawing.Point(0, 0);
            this.BemVindoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BemVindoText.Name = "BemVindoText";
            this.BemVindoText.Size = new System.Drawing.Size(161, 36);
            this.BemVindoText.TabIndex = 8;
            this.BemVindoText.Text = "Bem Vindo";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1149, 546);
            this.Controls.Add(this.BemVindoText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindoText;
    }
}