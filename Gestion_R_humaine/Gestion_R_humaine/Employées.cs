using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_R_humaine
{
    public partial class Employées : UserControl
    {
        ADO d = new ADO();

        public static int compt;
        public Employées()
        {
            InitializeComponent();
        }

        private void Employées_Load(object sender, EventArgs e)
        {
            d.connecter();

            remplirGrid();
            comboBox_sexe.Items.Add("Male");
            comboBox_sexe.Items.Add("Female");
            comboBox_sexe.Items.Add("Autre");
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        public void vider()
        {
            txt_matricule.Text = "";
            txt_nom_employé.Text = "";
            txt_prénom_employé.Text = "";
            txt_salaire.Text = "";
            txt_age.Text = "";
            txt_adresse.Text = "";
            txt_Poste_Travaille.Text = "";
            txt_nationalité.Text = "";
            txt_salaire.Text = "";
            txt_phone.Text = "";
            comboBox_sexe.Text = "";
            txt_carte_identité.Text = "";
            txt_compte_bancaire.Text = "";
            txt_date_embauche.Value = DateTime.Now;
            txt_date_naissance.Value = DateTime.Now;
        }

        public int nombre()
        {
            int cpt;
            d.cmd.CommandText = $"Select count(*) from employé where matricule like'{txt_search.Text}' or nom_employé like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
        }

        public int nombre(string matricule)
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
            d.cmd.CommandText = $"SELECT * FROM employé";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_employeés.DataSource = d.dt;
            d.dr.Close();
        }

        public void remplir_byMatNom()
        {
            DateTime datetime_1;
            DateTime datetime_2;
            /////  Remplissage de GridView  /////
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = $"SELECT * FROM [employé] where matricule like'{txt_search.Text}' or nom_employé like'{txt_search.Text}'";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dtg_employeés.DataSource = d.dt;
            d.dr.Close();
            /////  Remplissage de les textboxes  /////
            d.cmd.CommandText = $"select * from employé where matricule like'{txt_search.Text}' or nom_employé like'{txt_search.Text}'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                txt_matricule.Text = d.dr[0].ToString();
                txt_nom_employé.Text = d.dr[1].ToString();
                txt_prénom_employé.Text = d.dr[2].ToString();

                datetime_1 = DateTime.Parse(d.dr[3].ToString());
                txt_date_embauche.Text = datetime_1.ToString("dd-MM-yyyy");

                txt_salaire.Text = d.dr[4].ToString();
                txt_age.Text = d.dr[5].ToString();
                txt_adresse.Text = d.dr[6].ToString();
                txt_Poste_Travaille.Text = d.dr[7].ToString();
                txt_nationalité.Text = d.dr[8].ToString();
                txt_phone.Text = d.dr[9].ToString();
                comboBox_sexe.Text = d.dr[10].ToString();
                txt_carte_identité.Text = d.dr[11].ToString();

                datetime_2 = DateTime.Parse(d.dr[12].ToString());
                txt_date_naissance.Text = datetime_2.ToString("dd-MM-yyyy");

                txt_compte_bancaire.Text = d.dr[13].ToString();
            }
            d.dr.Close();
        }

        //Déclaration de la Méthode Supprimer
        public bool supprimer()
        {
            if (nombre() != 0)
            {
                d.cmd.CommandText = $"delete [employé] where matricule ='{txt_search.Text}'";
                d.cmd.Connection = d.con;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //Déclaration de la Méthode Ajouter
        public bool ajouter()
        {
            if (nombre(txt_matricule.Text) == 0)
            {
                try
                {
                    DateTime datetime_1 = DateTime.Parse(txt_date_embauche.Text);
                    DateTime datetime_2 = DateTime.Parse(txt_date_naissance.Text);
                    d.cmd.CommandText = $"exec proc_ajouter_emp_cmpt '{txt_matricule.Text}', '{txt_nom_employé.Text}', '{txt_prénom_employé.Text}', '{datetime_1.ToString("yyyy-MM-dd")}'," +
                       $" {txt_salaire.Text}, {txt_age.Text}, '{txt_adresse.Text}', '{txt_Poste_Travaille.Text}', '{txt_nationalité.Text}', '{ txt_phone.Text}'," +
                       $" '{comboBox_sexe.Text}','{txt_carte_identité.Text}','{datetime_2.ToString("yyyy-MM-dd")}', '{txt_compte_bancaire.Text}'";

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
            if (nombre(txt_matricule.Text) != 0)
            {
                try
                {
                    DateTime datetime_1 = DateTime.Parse(txt_date_embauche.Text);
                    DateTime datetime_2 = DateTime.Parse(txt_date_naissance.Text);

                    d.cmd.CommandText = $"update employé set nom_employé = '{txt_nom_employé.Text}', prénom_employé = '{txt_prénom_employé.Text}', date_embauche = '{datetime_1.ToString("yyyy-MM-dd")}', salaire = {txt_salaire.Text}" +
                        $", age = {txt_age.Text} , adresse = '{txt_adresse.Text}', poste_travaille = '{txt_Poste_Travaille.Text}', nationalité = '{txt_nationalité.Text}', phone = '{ txt_phone.Text}'" +
                        $", sexe = '{comboBox_sexe.Text}', carte_identité = '{txt_carte_identité.Text}', date_naissance = '{datetime_2.ToString("yyyy-MM-dd")}', compte_bancaire = '{txt_compte_bancaire.Text}'" +
                        $" where matricule = '{txt_matricule.Text}'";

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

            txt_matricule.Text = d.dt.Rows[compt][0].ToString();
            txt_nom_employé.Text = d.dt.Rows[compt][1].ToString();
            txt_prénom_employé.Text = d.dt.Rows[compt][2].ToString();

            datetime_1 = DateTime.Parse(d.dt.Rows[compt][3].ToString());
            txt_date_embauche.Text = datetime_1.ToString("dd-MM-yyyy");

            txt_salaire.Text = d.dt.Rows[compt][4].ToString();
            txt_age.Text = d.dt.Rows[compt][5].ToString();
            txt_adresse.Text = d.dt.Rows[compt][6].ToString();
            txt_Poste_Travaille.Text = d.dt.Rows[compt][7].ToString();
            txt_nationalité.Text = d.dt.Rows[compt][8].ToString();
            txt_phone.Text = d.dt.Rows[compt][9].ToString();
            comboBox_sexe.Text = d.dt.Rows[compt][10].ToString();
            txt_carte_identité.Text = d.dt.Rows[compt][11].ToString();

            datetime_2 = DateTime.Parse(d.dt.Rows[compt][12].ToString());
            txt_date_naissance.Text = datetime_2.ToString("dd-MM-yyyy");

            txt_compte_bancaire.Text = d.dt.Rows[compt][13].ToString();
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
                    remplir_byMatNom();
                }
                else
                {
                    MessageBox.Show("CETTE MATRICULE NEXIST PAS !!");
                    txt_search.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Remplez vous le text box !!");
                txt_search.Text = "";
            }
        }

        private void btn_anuller_Click(object sender, EventArgs e)
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
                    MessageBox.Show("A été Supprimer avec succès !!");
                    remplirGrid();
                    txt_search.Text = "";
                }
                else
                {
                    MessageBox.Show("CETTE MATRICULE NEXIST PAS !!");
                }
            }
            else
            {
                MessageBox.Show("Remplez vous le text box !!");
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (txt_matricule.Text == "" || txt_nom_employé.Text == "" || txt_salaire.Text == "" || txt_prénom_employé.Text == "" || txt_Poste_Travaille.Text == ""
                || txt_age.Text == "" || txt_carte_identité.Text == "" || txt_nationalité.Text == "" || txt_compte_bancaire.Text == "" || txt_phone.Text == ""
                || txt_adresse.Text == "" || comboBox_sexe.Text == "")
            {
                MessageBox.Show("Remplez vous les champs !!");
                txt_search.Text = "";
            }
            else
            {
                if (ajouter() == true)
                {
                    vider();
                    MessageBox.Show("A été Ajouté avec succès !!");
                    remplirGrid();
                }
                else
                {
                    txt_search.Text = "";
                    MessageBox.Show("Cette matricule exist déja !!");
                }
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (txt_matricule.Text == "" || txt_nom_employé.Text == "" || txt_salaire.Text == "" || txt_prénom_employé.Text == "" || txt_Poste_Travaille.Text == ""
                || txt_age.Text == "" || txt_carte_identité.Text == "" || txt_nationalité.Text == "" || txt_compte_bancaire.Text == "" || txt_phone.Text == ""
                || txt_adresse.Text == "" || comboBox_sexe.Text == "")
            {
                MessageBox.Show("Remplez vous les champs !!");
                txt_search.Text = "";
            }
            else
            {
                if (modifier() == true)
                {
                    vider();
                    MessageBox.Show("A été Modifier avec succès !!");
                    remplirGrid();
                }
                else
                {
                    MessageBox.Show("CETTE MATRICULE N'EXIST PAS !!");
                    txt_search.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            compt = 0;
            Navigation();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            compt = d.dt.Rows.Count - 1;
            Navigation();
        }
    }
}