
namespace Gestion_R_humaine
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom_utilisateur = new System.Windows.Forms.TextBox();
            this.txt_mot_passe = new System.Windows.Forms.TextBox();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_mot_passe_oblié = new System.Windows.Forms.LinkLabel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(641, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 559);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel2.BackgroundImage")));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(147, 182);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(96, 100);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 45);
            this.label4.TabIndex = 28;
            this.label4.Text = "GESTION D\'EMPLOYEES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(512, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nom_utilisateur
            // 
            this.txt_nom_utilisateur.Location = new System.Drawing.Point(512, 222);
            this.txt_nom_utilisateur.Multiline = true;
            this.txt_nom_utilisateur.Name = "txt_nom_utilisateur";
            this.txt_nom_utilisateur.Size = new System.Drawing.Size(358, 34);
            this.txt_nom_utilisateur.TabIndex = 3;
            // 
            // txt_mot_passe
            // 
            this.txt_mot_passe.Location = new System.Drawing.Point(512, 275);
            this.txt_mot_passe.Multiline = true;
            this.txt_mot_passe.Name = "txt_mot_passe";
            this.txt_mot_passe.Size = new System.Drawing.Size(358, 34);
            this.txt_mot_passe.TabIndex = 4;
            this.txt_mot_passe.TextChanged += new System.EventHandler(this.txt_mot_passe_TextChanged);
            // 
            // btn_connecter
            // 
            this.btn_connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connecter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connecter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_connecter.ForeColor = System.Drawing.Color.White;
            this.btn_connecter.Location = new System.Drawing.Point(512, 332);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(358, 37);
            this.btn_connecter.TabIndex = 5;
            this.btn_connecter.Text = "Se Connecter";
            this.btn_connecter.UseVisualStyleBackColor = false;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(550, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 1);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(948, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 33);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // lbl_mot_passe_oblié
            // 
            this.lbl_mot_passe_oblié.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_mot_passe_oblié.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mot_passe_oblié.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lbl_mot_passe_oblié.Location = new System.Drawing.Point(550, 423);
            this.lbl_mot_passe_oblié.Name = "lbl_mot_passe_oblié";
            this.lbl_mot_passe_oblié.Size = new System.Drawing.Size(291, 25);
            this.lbl_mot_passe_oblié.TabIndex = 9;
            this.lbl_mot_passe_oblié.TabStop = true;
            this.lbl_mot_passe_oblié.Text = "Mot De Passe Oblié";
            this.lbl_mot_passe_oblié.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mot_passe_oblié.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_mot_passe_oblié_LinkClicked);
            // 
            // lbl_msg
            // 
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_msg.ForeColor = System.Drawing.Color.Red;
            this.lbl_msg.Location = new System.Drawing.Point(547, 372);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(294, 23);
            this.lbl_msg.TabIndex = 25;
            this.lbl_msg.Text = "Cette compte n\'exist pas.";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(467, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 34);
            this.label2.TabIndex = 26;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(467, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 34);
            this.label3.TabIndex = 27;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_mot_passe_oblié);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_connecter);
            this.Controls.Add(this.txt_mot_passe);
            this.Controls.Add(this.txt_nom_utilisateur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom_utilisateur;
        private System.Windows.Forms.TextBox txt_mot_passe;
        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lbl_mot_passe_oblié;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}