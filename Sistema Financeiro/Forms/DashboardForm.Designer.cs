namespace Sistema_Financeiro
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeConta = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelApagar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelPago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NomeConta);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 110);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker2.Location = new System.Drawing.Point(400, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(321, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o Nome da Conta :";
            // 
            // NomeConta
            // 
            this.NomeConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeConta.Location = new System.Drawing.Point(26, 69);
            this.NomeConta.Name = "NomeConta";
            this.NomeConta.Size = new System.Drawing.Size(341, 26);
            this.NomeConta.TabIndex = 8;
            this.NomeConta.TextChanged += new System.EventHandler(this.NomeConta_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.AutoSize = true;
            this.iconButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(387, 61);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 44);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(364, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1370, 18);
            this.panel6.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 100);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel4.Controls.Add(this.labelApagar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(209, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 100);
            this.panel4.TabIndex = 4;
            // 
            // labelApagar
            // 
            this.labelApagar.AutoSize = true;
            this.labelApagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApagar.Location = new System.Drawing.Point(0, 25);
            this.labelApagar.Name = "labelApagar";
            this.labelApagar.Size = new System.Drawing.Size(213, 37);
            this.labelApagar.TabIndex = 1;
            this.labelApagar.Text = "10000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "A pagar :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 100);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1425, 18);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agendado";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 228);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1370, 21);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 249);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1370, 100);
            this.panel8.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel9.Controls.Add(this.labelSaldo);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(721, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(303, 100);
            this.panel9.TabIndex = 6;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(0, 25);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(213, 37);
            this.labelSaldo.TabIndex = 1;
            this.labelSaldo.Text = "10000000000";
            this.labelSaldo.Click += new System.EventHandler(this.labelSaldo_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saldo :";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(512, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(209, 100);
            this.panel10.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "Saldo Total";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel11.Controls.Add(this.labelPago);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(209, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(303, 100);
            this.panel11.TabIndex = 4;
            // 
            // labelPago
            // 
            this.labelPago.AutoSize = true;
            this.labelPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPago.Location = new System.Drawing.Point(0, 25);
            this.labelPago.Name = "labelPago";
            this.labelPago.Size = new System.Drawing.Size(213, 37);
            this.labelPago.TabIndex = 1;
            this.labelPago.Text = "10000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pago :";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(209, 100);
            this.panel12.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Concluido";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(47, 408);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(591, 300);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1370, 739);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeConta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}