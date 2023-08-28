namespace WebTechInscription
{
    partial class InscriptionForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPostNom = new System.Windows.Forms.Label();
            this.txtPostNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.CodeApp = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(192, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNom.Location = new System.Drawing.Point(154, 151);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 19);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(108, 183);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(142, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblPostNom
            // 
            this.lblPostNom.AutoSize = true;
            this.lblPostNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPostNom.Location = new System.Drawing.Point(154, 217);
            this.lblPostNom.Name = "lblPostNom";
            this.lblPostNom.Size = new System.Drawing.Size(78, 19);
            this.lblPostNom.TabIndex = 0;
            this.lblPostNom.Text = "Postnom";
            // 
            // txtPostNom
            // 
            this.txtPostNom.Location = new System.Drawing.Point(108, 249);
            this.txtPostNom.Name = "txtPostNom";
            this.txtPostNom.Size = new System.Drawing.Size(142, 20);
            this.txtPostNom.TabIndex = 2;
            this.txtPostNom.TextChanged += new System.EventHandler(this.txtPostNom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrenom.Location = new System.Drawing.Point(154, 282);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 19);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(108, 314);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(142, 20);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenre.Location = new System.Drawing.Point(336, 87);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(55, 19);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum.Location = new System.Drawing.Point(336, 151);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(92, 19);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "NumeroTel";
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(290, 183);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(142, 20);
            this.txtNumTel.TabIndex = 5;
            this.txtNumTel.TextChanged += new System.EventHandler(this.txtNumTel_TextChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMontant.Location = new System.Drawing.Point(336, 282);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(71, 19);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(290, 314);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(142, 20);
            this.txtMontant.TabIndex = 7;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdresse.Location = new System.Drawing.Point(336, 215);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(72, 19);
            this.lblAdresse.TabIndex = 0;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(290, 247);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(142, 20);
            this.txtAdresse.TabIndex = 6;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // cbxGenre
            // 
            this.cbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxGenre.Location = new System.Drawing.Point(303, 118);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(121, 21);
            this.cbxGenre.TabIndex = 4;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAjouter.Image = global::WebTechInscription.Properties.Resources.icons8_ok_30px;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(226, 417);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 47);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 376);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(243, 348);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 19);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // CodeApp
            // 
            this.CodeApp.AutoSize = true;
            this.CodeApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CodeApp.Location = new System.Drawing.Point(153, 87);
            this.CodeApp.Name = "CodeApp";
            this.CodeApp.Size = new System.Drawing.Size(81, 19);
            this.CodeApp.TabIndex = 0;
            this.CodeApp.Text = "CodeApp";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(107, 119);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(142, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 476);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtPostNom);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblPostNom);
            this.Controls.Add(this.CodeApp);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscriptionForm";
            this.Load += new System.EventHandler(this.InscriptionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPostNom;
        private System.Windows.Forms.TextBox txtPostNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label CodeApp;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}