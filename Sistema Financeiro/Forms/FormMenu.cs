using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Sistema_Financeiro.Forms;
namespace Sistema_Financeiro { 
    public partial class SistemaFinanceiro : Form
    {
        bool sideBarExpand;

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //constructor
        public SistemaFinanceiro()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        //structs
        private struct RGBColors
        {
            public static Color black = Color.FromArgb(15, 15, 15);
            public static Color highlight = Color.FromArgb(45, 45, 45);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;  
                currentBtn.BackColor = Color.FromArgb(45, 45, 45);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Top);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(15, 15, 15);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
               
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            DashboardPanel.Controls.Add(childForm);
            DashboardPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //openChildForm(new DashboardForm());
        //ActivateButton(sender, RGBColors.highlight);
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new DashboardForm());
        }
        private void BtnCadastros_Click(object sender, EventArgs e)

        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new CadastrosForm());
        }
        private void BtnFinanceiro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new FinanceiroForm());
        }
        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new ConfiguracoesForm());
        }
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new DashboardForm());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
            openChildForm(new MenuForm());

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                panelMenu.Width = 250;
                sideBarExpand = false;
            }
            else
            {
                panelMenu.Width = 60;
                sideBarExpand = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            notificacoesBox.Multiline = true;
            notificacoesBox.ScrollBars = ScrollBars.Both;
        }

        private void Notificacoes_Click(object sender, EventArgs e)
        {

        }
    }
}
