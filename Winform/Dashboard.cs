﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
  (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
      int nHeightEllipse

   );
        public Dashboard()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

               private void Analytics_btn_Click(object sender, EventArgs e)
        {
            NavPanel_lbl.Height = Analytics_btn.Height;
            NavPanel_lbl.Top = Analytics_btn.Top;
            Analytics_btn.BackColor = Color.FromArgb(240, 128, 128);
            Analytics f3 = new Analytics();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            NavPanel_lbl.Height = Sales_btn.Height;
            NavPanel_lbl.Top = Sales_btn.Top;
            Sales_btn.BackColor = Color.FromArgb(240, 128, 128);
                Sales_Report f2 = new Sales_Report();
                this.Hide();
                f2.ShowDialog();
                this.Show();
        }


        private void Expenditure_btn_Click(object sender, EventArgs e)
        {
            NavPanel_lbl.Height = Invoices_btn.Height;
            NavPanel_lbl.Top = Invoices_btn.Top;
            Invoices_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            NavPanel_lbl.Height = Settings_btn.Height;
            NavPanel_lbl.Top = Settings_btn.Top;
            Settings_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void Analytics_btn_Leave(object sender, EventArgs e)
        {
            Analytics_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void Sales_btn_Leave(object sender, EventArgs e)
        {
            Sales_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void Expenditure_btn_Leave(object sender, EventArgs e)
        {
            Invoices_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void Settings_btn_Leave(object sender, EventArgs e)
        {
            Settings_btn.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void user_namebox_Click(object sender, EventArgs e)
        {
            string tb_UserName = null;
            user_namebox.Text = tb_UserName;
        }
    }
}