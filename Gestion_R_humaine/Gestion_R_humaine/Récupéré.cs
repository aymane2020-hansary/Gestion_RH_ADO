using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Récupéré : Form
    {
        ADO d = new ADO();
        public Récupéré()
        {
            InitializeComponent();
        }

        private void Récupéré_Load(object sender, EventArgs e)
        {
            d.connecter();

            lbl_msg.Visible = false;
            txt_nom_utilisateur.ReadOnly = true;
            txt_mot_passe.ReadOnly = true;
        }

        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from compte where Nom_grand_pere like '{txt_nom_grand_pére.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public void méthode_récupéré()
        {
            d.cmd.CommandText = $"select nom_utilisateur, mot_passe from compte where Nom_grand_pere = '{txt_nom_grand_pére.Text}'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                txt_nom_utilisateur.Text = d.dr[0].ToString();
                txt_mot_passe.Text = d.dr[1].ToString();
            }
            d.dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if (nombre() != 0)
            {
                méthode_récupéré();
                
                Global_session.nom_grand_pere = txt_nom_grand_pére.Text;

                lbl_msg.ForeColor =Color.Green;
                lbl_msg.Visible = true;
                lbl_msg.Text = "Le compte a été récupéré avec succès";
            }
            else
            {
                lbl_msg.ForeColor = Color.Red;
                lbl_msg.Visible = true;
                lbl_msg.Text = "Cette réponse incorrect";
            }
        }
    }
}