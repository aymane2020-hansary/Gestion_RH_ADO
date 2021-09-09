using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class List_projets : UserControl
    {
        ADO d = new ADO();

        public static int compt;
        public List_projets()
        {
            InitializeComponent();
        }

        private void List_projets_Load(object sender, EventArgs e)
        {
            d.connecter();
            remplirGrid();
        }

        public void vider()
        {
            txt_référence.Text = "";
            txt_nom_projet.Text = "";
            txt_desc_projet.Text = "";
            txt_budget.Text = "";
            txt_mat_chéf_projet.Text = "";
            txt_nom_chéf_projet.Text = "";
            txt_date_début.Value = DateTime.Now;
            txt_date_fin.Value = DateTime.Now;
        }

        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from projet where référence like'{txt_search.Text}' or nom_projet like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre(string référence)
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from projet where référence like'{référence}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre_(string matricule)
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from employé where matricule like'{matricule}'";
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
            d.cmd.CommandText = $"SELECT * FROM projet";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_list_projets.DataSource = d.dt;
            d.dr.Close();
        }

        public void remplir_byRéfNom()
        {
            DateTime datetime_1;
            DateTime datetime_2;
            /////  Remplissage de GridView  /////
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = $"SELECT * FROM projet where référence like'{txt_search.Text}' or nom_projet like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_list_projets.DataSource = d.dt;
            d.dr.Close();
            /////  Remplissage de les textboxes  /////
            d.cmd.CommandText = $"select * from projet where référence like'{txt_search.Text}' or nom_projet like'{txt_search.Text}'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                txt_référence.Text = d.dr[0].ToString();
                txt_nom_projet.Text = d.dr[1].ToString();
                txt_desc_projet.Text = d.dr[2].ToString();
                txt_budget.Text = d.dr[3].ToString();
                txt_mat_chéf_projet.Text = d.dr[4].ToString();
                txt_nom_chéf_projet.Text = d.dr[5].ToString();
                datetime_1 = DateTime.Parse(d.dr[6].ToString());
                txt_date_début.Text = datetime_1.ToString("dd-MM-yyyy");
                datetime_2 = DateTime.Parse(d.dr[7].ToString());
                txt_date_fin.Text = datetime_2.ToString("dd-MM-yyyy");
            }
            d.dr.Close();
        }

        //Déclaration de la Méthode Supprimer
        public bool supprimer()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = $"delete projet where référence ='{txt_search.Text}'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //Déclaration de la Méthode Ajouter
        public bool ajouter()
        {
            if (nombre(txt_référence.Text) == 0 && nombre_(txt_mat_chéf_projet.Text) != 0)
            {
                try
                {
                    DateTime datetime_1 = DateTime.Parse(txt_date_début.Text);
                    DateTime datetime_2 = DateTime.Parse(txt_date_fin.Text);
                    d.cmd.CommandText = $"insert into projet values('{txt_référence.Text}','{txt_nom_projet.Text}','{txt_desc_projet.Text}',{txt_budget.Text}" +
                        $",'{txt_mat_chéf_projet.Text}','{txt_nom_chéf_projet.Text}','{datetime_1.ToString("yyyy-MM-dd")}','{datetime_2.ToString("yyyy-MM-dd")}')";

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
        //Déclaration de la Méthode modifier
        public bool modifier()
        {
            if (nombre(txt_référence.Text) != 0 && nombre_(txt_mat_chéf_projet.Text) != 0)
            {
                try
                {
                    DateTime datetime_1 = DateTime.Parse(txt_date_début.Text);
                    DateTime datetime_2 = DateTime.Parse(txt_date_fin.Text);
                    d.cmd.CommandText = $"update projet set nom_projet = '{txt_nom_projet.Text}', description_projet = '{txt_desc_projet.Text}', budget = {txt_budget.Text}" +
                        $", matricule_chéf_projet = '{txt_mat_chéf_projet.Text}' , nom_chéf_projet = '{txt_nom_chéf_projet.Text}', date_début = '{datetime_1.ToString("yyyy-MM-dd")}', date_fin = '{datetime_2.ToString("yyyy-MM-dd")}'" +
                        $" where référence = '{txt_référence.Text}'";

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
            DateTime datetime_1;
            DateTime datetime_2;

            txt_référence.Text = d.dt.Rows[compt][0].ToString();
            txt_nom_projet.Text = d.dt.Rows[compt][1].ToString();
            txt_desc_projet.Text = d.dt.Rows[compt][2].ToString();
            txt_budget.Text = d.dt.Rows[compt][3].ToString();
            txt_mat_chéf_projet.Text = d.dt.Rows[compt][4].ToString();
            txt_nom_chéf_projet.Text = d.dt.Rows[compt][5].ToString();
            datetime_1 = DateTime.Parse(d.dt.Rows[compt][6].ToString());
            txt_date_début.Text = datetime_1.ToString("dd-MM-yyyy");
            datetime_2 = DateTime.Parse(d.dt.Rows[compt][7].ToString());
            txt_date_fin.Text = datetime_2.ToString("dd-MM-yyyy");
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
                    remplir_byRéfNom();
                }
                else
                {
                    MessageBox.Show("Cette référece n'existe pas !!");
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
            if (txt_search.Text != "")
            {
                if (supprimer() == true)
                {
                    MessageBox.Show("A été supprimer avec succès !!");
                    remplirGrid();
                    txt_search.Text = "";
                }
                else
                {
                    MessageBox.Show("Cette référence n'exist pas !!");
                }
            }
            else
            {
                MessageBox.Show("Remplez vous le text box !!");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_référence.Text == "" || txt_nom_projet.Text == "" || txt_desc_projet.Text == "" || txt_budget.Text == "" || txt_mat_chéf_projet.Text == ""
                || txt_nom_chéf_projet.Text == "" || (System.Text.RegularExpressions.Regex.IsMatch(txt_budget.Text, "[^0-9]")))
            {
                MessageBox.Show("Remplez vous les champs !!");
                txt_search.Text = "";
            }
            else
            {
                if (ajouter() == true)
                {
                    MessageBox.Show("A été Ajouté avec succès !!");
                    vider();
                    remplirGrid();
                }
                else
                {
                    txt_search.Text = "";
                    MessageBox.Show("Verifier les champs. \nCette référence exist déja Ou le matricule n'exist pas !!");
                }
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_référence.Text == "" || txt_nom_projet.Text == "" || txt_desc_projet.Text == "" || txt_budget.Text == "" || txt_mat_chéf_projet.Text == ""
                || txt_nom_chéf_projet.Text == "" || (System.Text.RegularExpressions.Regex.IsMatch(txt_budget.Text, "[^0-9]")))
            {
                MessageBox.Show("Remplez vous les champs !!");
                txt_search.Text = "";
            }
            else
            {
                if (modifier() == true)
                {
                    try
                    {
                        txt_search.Text = "";
                        vider();
                        remplirGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Verifier les champs. \nCette référence Ou le matricule n'exist pas !!");
                    txt_search.Text = "";
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