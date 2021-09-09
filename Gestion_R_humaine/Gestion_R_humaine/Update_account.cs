using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Update_account : UserControl
    {
        ADO d = new ADO();
        public Update_account()
        {
            InitializeComponent();
        }

        private void Update_account_Load(object sender, EventArgs e)
        {
            d.connecter();

            txt_matricule.Text = Global_session.Matrucile;
            txt_nom_employé.Text = Global_session.nom_employé;
            txt_prénom_employé.Text = Global_session.prénom_employé;

            txt_matricule.ReadOnly = true;
            txt_nom_employé.ReadOnly = true;
            txt_prénom_employé.ReadOnly = true;
        }

        public void vider()
        {
            txt_new_user_name.Text = "";
            txt_new_password.Text = "";
            txt_new_grand_pére.Text = "";
        }

        public void méthode_modifier_compte()
        {
            d.cmd.CommandText = $"update compte set nom_utilisateur = '{txt_new_user_name.Text}', mot_passe = '{txt_new_password.Text}', Nom_grand_pere = '{txt_new_grand_pére.Text}'  where matricule = '{Global_session.Matrucile}'";
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_new_user_name.Text != "" && txt_new_password.Text != "" && txt_new_grand_pére.Text != "")
            {
                try
                {
                    méthode_modifier_compte();
                    vider();

                    MessageBox.Show("Le compte a éte modifié avec succès !!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Remplir Les champs !!");
                vider();
            }
        }
    }
}