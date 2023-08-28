namespace WebTechInscription
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModule = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPaiement = new System.Windows.Forms.Button();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WebTechInscription.Properties.Resources.icons8_undo_50px;
            this.button1.Location = new System.Drawing.Point(624, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Technology";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebTechInscription.Properties.Resources.WebTecnology_Formation_20211023_115656;
            this.pictureBox1.Location = new System.Drawing.Point(0, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 13);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnModule);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.btnPaiement);
            this.panel3.Controls.Add(this.btnInscription);
            this.panel3.Controls.Add(this.btnAccueil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 65);
            this.panel3.TabIndex = 3;
            // 
            // btnModule
            // 
            this.btnModule.FlatAppearance.BorderSize = 0;
            this.btnModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModule.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModule.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnModule.Image = global::WebTechInscription.Properties.Resources.icons8_module_50px;
            this.btnModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModule.Location = new System.Drawing.Point(143, 0);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(134, 65);
            this.btnModule.TabIndex = 2;
            this.btnModule.Text = "Module";
            this.btnModule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Image = global::WebTechInscription.Properties.Resources.icons8_report_card_filled_50px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(577, -3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 65);
            this.button5.TabIndex = 2;
            this.button5.Text = "Rapports";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnPaiement
            // 
            this.btnPaiement.FlatAppearance.BorderSize = 0;
            this.btnPaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaiement.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaiement.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPaiement.Image = global::WebTechInscription.Properties.Resources.icons8_online_payment__filled_50px;
            this.btnPaiement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaiement.Location = new System.Drawing.Point(436, -3);
            this.btnPaiement.Name = "btnPaiement";
            this.btnPaiement.Size = new System.Drawing.Size(134, 65);
            this.btnPaiement.TabIndex = 2;
            this.btnPaiement.Text = "Paiement";
            this.btnPaiement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaiement.UseVisualStyleBackColor = true;
            this.btnPaiement.Click += new System.EventHandler(this.btnPaiement_Click);
            // 
            // btnInscription
            // 
            this.btnInscription.FlatAppearance.BorderSize = 0;
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInscription.Image = global::WebTechInscription.Properties.Resources.icons8_inscription_50px;
            this.btnInscription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscription.Location = new System.Drawing.Point(293, -3);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(139, 65);
            this.btnInscription.TabIndex = 2;
            this.btnInscription.Text = "Inscription";
            this.btnInscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnAccueil
            // 
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccueil.Image = global::WebTechInscription.Properties.Resources.icons8_home_filled_50px;
            this.btnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccueil.Location = new System.Drawing.Point(3, 0);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(134, 65);
            this.btnAccueil.TabIndex = 2;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(0, 178);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(711, 361);
            this.pnlShow.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 539);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPaiement;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Button btnModule;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

