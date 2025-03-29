using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;   

namespace Sistema_Financeiro { 
    public partial class SistemaFinanceiro : Form
    {

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

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
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
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
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //BtnDashboard
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }
        private void BtnFinanceiro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.highlight);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
