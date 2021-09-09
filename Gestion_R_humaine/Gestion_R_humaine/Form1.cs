using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SideLabel.Height = button1.Height;
            SideLabel.Top = button1.Top;
            home2.BringToFront();

            lbl_profile.Text = "Bienvenue, " + Global_session.nom_employé;

            if (Global_session.statu == "admin" || Global_session.statu == "ADMIN")
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button14.Visible = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button14.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button1.Height;
            SideLabel.Top = button1.Top;
            home2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button2.Height;
            SideLabel.Top = button2.Top;
            employées1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button3.Height;
            SideLabel.Top = button3.Top;
            list_projets1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button4.Height;
            SideLabel.Top = button4.Top;
            liste_Affectation1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button13.Height;
            SideLabel.Top = button13.Top;
            document_emp1.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button14.Height;
            SideLabel.Top = button14.Top;
            document_tout_emp1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button5.Height;
            SideLabel.Top = button5.Top;
            update_account1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SideLabel.Height = button6.Height;
            SideLabel.Top = button6.Top;

            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void btn_déconnecter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}