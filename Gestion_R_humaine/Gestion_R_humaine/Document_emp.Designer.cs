
namespace Gestion_R_humaine
{
    partial class Document_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document_emp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_profile = new System.Windows.Forms.Label();
            this.dtg_doc_infos = new System.Windows.Forms.DataGridView();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doc_infos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(9, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 46);
            this.panel2.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(150)))), ((int)(((byte)(219)))));
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(18, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "          Document Informations";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_profile
            // 
            this.lbl_profile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_profile.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_profile.Location = new System.Drawing.Point(386, 117);
            this.lbl_profile.Name = "lbl_profile";
            this.lbl_profile.Size = new System.Drawing.Size(547, 48);
            this.lbl_profile.TabIndex = 38;
            this.lbl_profile.Text = "Document ...";
            this.lbl_profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_doc_infos
            // 
            this.dtg_doc_infos.AllowUserToAddRows = false;
            this.dtg_doc_infos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_doc_infos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doc_infos.Location = new System.Drawing.Point(9, 213);
            this.dtg_doc_infos.Name = "dtg_doc_infos";
            this.dtg_doc_infos.RowHeadersWidth = 51;
            this.dtg_doc_infos.RowTemplate.Height = 29;
            this.dtg_doc_infos.Size = new System.Drawing.Size(1307, 388);
            this.dtg_doc_infos.TabIndex = 39;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(1085, 633);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(231, 37);
            this.btn_imprimer.TabIndex = 40;
            this.btn_imprimer.Text = "Imprimer ";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // Document_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.dtg_doc_infos);
            this.Controls.Add(this.lbl_profile);
            this.Controls.Add(this.panel2);
            this.Name = "Document_emp";
            this.Size = new System.Drawing.Size(1335, 720);
            this.Load += new System.EventHandler(this.Document_emp_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doc_infos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_profile;
        private System.Windows.Forms.DataGridView dtg_doc_infos;
        private System.Windows.Forms.Button btn_imprimer;
    }
}
