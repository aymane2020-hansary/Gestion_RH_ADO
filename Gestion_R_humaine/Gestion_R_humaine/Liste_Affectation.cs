using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Liste_Affectation : UserControl
    {
        ADO d = new ADO();

        public static int compt;
        public Liste_Affectation()
        {
            InitializeComponent();
        }

        private void Liste_Affectation_Load(object sender, EventArgs e)
        {
            d.connecter();
            remplirGrid();
        }

        public void vider()
        {
            txt_id.Text = "";
            txt_matricule.Text = "";
            txt_nom_employé.Text = "";
            txt_prénom_employé.Text = "";
            txt_poste_travaille.Text = "";
            txt_référence.Text = "";
            txt_nom_projet.Text = "";
            txt_nom_chéf_projet.Text = "";
        }

        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from Liste_Affectation where Id like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre_4()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from employé where matricule like'{txt_matricule.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre_2(int id)
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from Liste_Affectation where id = '{id}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre_3()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from projet where référence like'{txt_référence.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public void remplirGrid()
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = $"SELECT * FROM Liste_Affectation";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_list_affictation.DataSource = d.dt;
            d.dr.Close();
        }

        public void remplir_byId()
        {
            /////  Remplissage de GridView  /////
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = $"SELECT * FROM Liste_Affectation where Id like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_list_affictation.DataSource = d.dt;
            d.dr.Close();
        }

        //Déclaration de la Méthode Supprimer
        public bool supprimer()
        {
            if (nombre_2(Int32.Parse(txt_search.Text)) != 0)
            {
                d.cmd.CommandText = $"delete Liste_Affectation where Id ='{txt_search.Text}'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //Déclaration de la Méthode Ajouter
        public bool ajouter()
        {
            if ((nombre_4() != 0) && (nombre_3() != 0))
            {
                try
                {
                    d.cmd.CommandText = $"insert into Liste_Affectation values('{txt_matricule.Text}','{txt_nom_employé.Text}','{txt_prénom_employé.Text}','{txt_poste_travaille.Text}'" +
                    $",'{txt_référence.Text}','{txt_nom_projet.Text}','{txt_nom_chéf_projet.Text}');";

                    d.cmd.Connection = d.con;
                    d.cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return true;
            }
            return false;
        }

        public void Navigation()
        {
            txt_id.Text = d.dt.Rows[compt][0].ToString();
            txt_matricule.Text = d.dt.Rows[compt][1].ToString();
            txt_nom_employé.Text = d.dt.Rows[compt][2].ToString();
            txt_prénom_employé.Text = d.dt.Rows[compt][3].ToString();
            txt_poste_travaille.Text = d.dt.Rows[compt][4].ToString();
            txt_référence.Text = d.dt.Rows[compt][5].ToString();
            txt_nom_projet.Text = d.dt.Rows[compt][6].ToString();
            txt_nom_chéf_projet.Text = d.dt.Rows[compt][7].ToString();
        }

        private void btn_afficher_tout_Click(object sender, EventArgs e)
        {
            vider();
            txt_search.Text = "";
            remplirGrid();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            vider();

            if (txt_search.Text != "")
            {
                if (nombre() != 0)
                {
                    remplir_byId();
                }
                else
                {
                    MessageBox.Show("Cette id n'existe pas !!");
                    txt_search.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Remplez vous le text box !!");
                txt_search.Text = "";
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            vider();
            txt_search.Text = "";
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "" && (!System.Text.RegularExpressions.Regex.IsMatch(txt_search.Text, "[^0-9]")))
            {
                if (supprimer() == true)
                {
                    MessageBox.Show("A été supprimer avec succès !!");
                    remplirGrid();
                    txt_search.Text = "";
                }
                else
                {
                    MessageBox.Show("Cette id n'exist pas !!");
                }
            }
            else
            {
                MessageBox.Show("Vous Ne Pouvez Supprimer Que Par ID !!");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_matricule.Text == "" || txt_nom_employé.Text == "" || txt_prénom_employé.Text == "" || txt_poste_travaille.Text == "" || txt_référence.Text == ""
                || txt_nom_projet.Text == "" || txt_nom_chéf_projet.Text == "")
            {
                MessageBox.Show("Remplez vous les champs !!");
                txt_search.Text = "";
            }
            else
            {
                if (ajouter() == true)
                {
                    remplirGrid();
                    MessageBox.Show("A été Ajouté avec succès !!");
                    vider();
                }
                else
                {
                    MessageBox.Show("Cette matricule Ou référence n'exist pas !!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compt = 0;
            Navigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try //Essayer  ça
            {
                compt--;
                Navigation();
            }
            catch
            {
                //L'enregistrement
                MessageBox.Show("Vous etes dans le première enregistrement");
                compt++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                compt++;
                Navigation();
            }
            catch
            {
                //L'enregistrement
                MessageBox.Show("Vous etes dans le dernier enregistrement");
                compt--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compt = d.dt.Rows.Count - 1;
            Navigation();
        }
    }
}