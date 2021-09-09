
namespace Gestion_R_humaine
{
    partial class List_projets
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_projets));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dtg_list_projets = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_date_début = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_référence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_projet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mat_chéf_projet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_date_fin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nom_chéf_projet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_desc_projet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_budget = new System.Windows.Forms.TextBox();
            this.btn_afficher_tout = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list_projets)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(14, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 46);
            this.panel2.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.LimeGreen;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(18, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "          List projets";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtg_list_projets
            // 
            this.dtg_list_projets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_list_projets.Location = new System.Drawing.Point(14, 359);
            this.dtg_list_projets.Name = "dtg_list_projets";
            this.dtg_list_projets.RowHeadersWidth = 51;
            this.dtg_list_projets.RowTemplate.Height = 29;
            this.dtg_list_projets.Size = new System.Drawing.Size(1307, 340);
            this.dtg_list_projets.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txt_date_début);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.txt_référence);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nom_projet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_mat_chéf_projet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_date_fin);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_nom_chéf_projet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_desc_projet);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_budget);
            this.panel1.Location = new System.Drawing.Point(14, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 223);
            this.panel1.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(0, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 1);
            this.panel3.TabIndex = 36;
            // 
            // txt_date_début
            // 
            this.txt_date_début.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date_début.Location = new System.Drawing.Point(822, 112);
            this.txt_date_début.Name = "txt_date_début";
            this.txt_date_début.Size = new System.Drawing.Size(242, 27);
            this.txt_date_début.TabIndex = 34;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(564, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(152, 29);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Rechercher";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(294, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(242, 27);
            this.txt_search.TabIndex = 32;
            // 
            // txt_référence
            // 
            this.txt_référence.Location = new System.Drawing.Point(24, 111);
            this.txt_référence.Name = "txt_référence";
            this.txt_référence.Size = new System.Drawing.Size(242, 27);
            this.txt_référence.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Référence*";
            // 
            // txt_nom_projet
            // 
            this.txt_nom_projet.Location = new System.Drawing.Point(24, 174);
            this.txt_nom_projet.Name = "txt_nom_projet";
            this.txt_nom_projet.Size = new System.Drawing.Size(242, 27);
            this.txt_nom_projet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom projet*";
            // 
            // txt_mat_chéf_projet
            // 
            this.txt_mat_chéf_projet.Location = new System.Drawing.Point(556, 112);
            this.txt_mat_chéf_projet.Name = "txt_mat_chéf_projet";
            this.txt_mat_chéf_projet.Size = new System.Drawing.Size(242, 27);
            this.txt_mat_chéf_projet.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(552, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matricule chéf projet*";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(818, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(242, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Date fin*";
            // 
            // txt_date_fin
            // 
            this.txt_date_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date_fin.Location = new System.Drawing.Point(822, 173);
            this.txt_date_fin.Name = "txt_date_fin";
            this.txt_date_fin.Size = new System.Drawing.Size(242, 27);
            this.txt_date_fin.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(819, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date début*";
            // 
            // txt_nom_chéf_projet
            // 
            this.txt_nom_chéf_projet.Location = new System.Drawing.Point(556, 174);
            this.txt_nom_chéf_projet.Name = "txt_nom_chéf_projet";
            this.txt_nom_chéf_projet.Size = new System.Drawing.Size(242, 27);
            this.txt_nom_chéf_projet.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(553, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nom chéf projet*";
            // 
            // txt_desc_projet
            // 
            this.txt_desc_projet.Location = new System.Drawing.Point(294, 111);
            this.txt_desc_projet.Name = "txt_desc_projet";
            this.txt_desc_projet.Size = new System.Drawing.Size(242, 27);
            this.txt_desc_projet.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(291, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Budget*";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(290, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Description projet*";
            // 
            // txt_budget
            // 
            this.txt_budget.Location = new System.Drawing.Point(294, 173);
            this.txt_budget.Name = "txt_budget";
            this.txt_budget.Size = new System.Drawing.Size(242, 27);
            this.txt_budget.TabIndex = 18;
            // 
            // btn_afficher_tout
            // 
            this.btn_afficher_tout.BackColor = System.Drawing.Color.Ivory;
            this.btn_afficher_tout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_afficher_tout.ForeColor = System.Drawing.Color.Black;
            this.btn_afficher_tout.Location = new System.Drawing.Point(1140, 273);
            this.btn_afficher_tout.Name = "btn_afficher_tout";
            this.btn_afficher_tout.Size = new System.Drawing.Size(157, 36);
            this.btn_afficher_tout.TabIndex = 41;
            this.btn_afficher_tout.Text = "Afficher tout";
            this.btn_afficher_tout.UseVisualStyleBackColor = false;
            this.btn_afficher_tout.Click += new System.EventHandler(this.btn_afficher_tout_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Crimson;
            this.btn_annuler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_annuler.FlatAppearance.BorderSize = 0;
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(1140, 221);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(157, 35);
            this.btn_annuler.TabIndex = 40;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.DeepPink;
            this.btn_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(1140, 185);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(157, 33);
            this.btn_supprimer.TabIndex = 39;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.Navy;
            this.btn_modifier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(1140, 146);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(157, 35);
            this.btn_modifier.TabIndex = 38;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ajouter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(1140, 107);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(157, 33);
            this.btn_ajouter.TabIndex = 37;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(880, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 29);
            this.button3.TabIndex = 48;
            this.button3.Text = "Dernier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(728, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 29);
            this.button4.TabIndex = 47;
            this.button4.Text = "Suivant";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(280, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 46;
            this.button2.Text = "Précedent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(123, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_projets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_list_projets);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_afficher_tout);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "List_projets";
            this.Size = new System.Drawing.Size(1335, 720);
            this.Load += new System.EventHandler(this.List_projets_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list_projets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtg_list_projets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_référence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_projet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mat_chéf_projet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txt_date_fin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nom_chéf_projet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_desc_projet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_budget;
        private System.Windows.Forms.Button btn_afficher_tout;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DateTimePicker txt_date_début;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
