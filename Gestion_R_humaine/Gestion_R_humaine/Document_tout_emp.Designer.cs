
namespace Gestion_R_humaine
{
    partial class Document_tout_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document_tout_emp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.dtg_doc_infos_tout = new System.Windows.Forms.DataGridView();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doc_infos_tout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(14, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 46);
            this.panel2.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(18, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "          Document tout";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(1090, 651);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(231, 37);
            this.btn_imprimer.TabIndex = 44;
            this.btn_imprimer.Text = "Imprimer ";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // dtg_doc_infos_tout
            // 
            this.dtg_doc_infos_tout.AllowUserToAddRows = false;
            this.dtg_doc_infos_tout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_doc_infos_tout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doc_infos_tout.Location = new System.Drawing.Point(14, 231);
            this.dtg_doc_infos_tout.Name = "dtg_doc_infos_tout";
            this.dtg_doc_infos_tout.RowHeadersWidth = 51;
            this.dtg_doc_infos_tout.RowTemplate.Height = 29;
            this.dtg_doc_infos_tout.Size = new System.Drawing.Size(1307, 388);
            this.dtg_doc_infos_tout.TabIndex = 43;
            // 
            // lbl_profile
            // 
            this.lbl_profile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_profile.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_profile.Location = new System.Drawing.Point(391, 135);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(547, 48);
            this.lbl_profile.TabIndex = 42;
            this.lbl_profile.Text = "Document Informations de tous employés";
            this.lbl_profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Document_tout_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.dtg_doc_infos_tout);
            this.Controls.Add(this.lbl_profile);
            this.Name = "Document_tout_emp";
            this.Size = new System.Drawing.Size(1335, 720);
            this.Load += new System.EventHandler(this.Document_tout_emp_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doc_infos_tout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.DataGridView dtg_doc_infos_tout;
        private System.Windows.Forms.Label lbl_profile;
    }
}
