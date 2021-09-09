using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Login : Form
    {
        ADO d = new ADO();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            d.connecter();

            txt_mot_passe.PasswordChar = '*';
            lbl_msg.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from compte where nom_utilisateur like '{txt_nom_utilisateur.Text}' and mot_passe like '{txt_mot_passe.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public void nb_employées()
        {
            d.cmd.CommandText = $"select count(*) from employé;";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                Global_session.nb_employées = d.dr[0].ToString();
            }
            d.dr.Close();
        }
        
        public void nb_projets()
        {
            d.cmd.CommandText = $"select count(*) from projet;";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                Global_session.nb_projets = d.dr[0].ToString();
            }
            d.dr.Close();
        }
        
        public void Remplissage_sessions()
        {
            d.cmd.CommandText = $"select matricule, nom_utilisateur from compte where nom_utilisateur = '{txt_nom_utilisateur.Text}'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                Global_session.Matrucile = d.dr[0].ToString();
                Global_session.Nom_Utilisateur = d.dr[1].ToString();
            }
            d.dr.Close();

            d.cmd.CommandText = $"select nom_employé, prénom_employé, poste_travaille from employé where matricule = '{Global_session.Matrucile}'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                Global_session.nom_employé = d.dr[0].ToString();
                Global_session.prénom_employé = d.dr[1].ToString();
                Global_session.statu = d.dr[2].ToString();
            }
            d.dr.Close();
        }
        
        private void lbl_mot_passe_oblié_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Récupéré r = new Récupéré();
            r.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if (nombre() != 0)
            {
                ////  remplir_session ////
                Remplissage_sessions();

                ////  Nb_employées ////

                nb_employées();
                ////  Nb_projets  ////

                nb_projets();
                /////////////////////
               
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                this.lbl_msg.Visible = true;
            }
        }

        private void txt_mot_passe_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
