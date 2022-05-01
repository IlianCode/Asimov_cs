namespace Asimov_cspc.proviseur.listeEleves
{
    partial class ajtEleveProviseur
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMatiereProf = new System.Windows.Forms.Label();
            this.buttonCreerEleve = new System.Windows.Forms.Button();
            this.textBoxMdpEleve = new System.Windows.Forms.TextBox();
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.labelMdpProf = new System.Windows.Forms.Label();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.labelNomProf = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // labelMatiereProf
            // 
            this.labelMatiereProf.AutoSize = true;
            this.labelMatiereProf.Location = new System.Drawing.Point(183, 196);
            this.labelMatiereProf.Name = "labelMatiereProf";
            this.labelMatiereProf.Size = new System.Drawing.Size(44, 13);
            this.labelMatiereProf.TabIndex = 29;
            this.labelMatiereProf.Text = "Classe: ";
            // 
            // buttonCreerEleve
            // 
            this.buttonCreerEleve.Location = new System.Drawing.Point(116, 260);
            this.buttonCreerEleve.Name = "buttonCreerEleve";
            this.buttonCreerEleve.Size = new System.Drawing.Size(164, 23);
            this.buttonCreerEleve.TabIndex = 28;
            this.buttonCreerEleve.Text = "Ajouter un professeur";
            this.buttonCreerEleve.UseVisualStyleBackColor = true;
            this.buttonCreerEleve.Click += new System.EventHandler(this.buttonCreerEleve_Click);
            // 
            // textBoxMdpEleve
            // 
            this.textBoxMdpEleve.Location = new System.Drawing.Point(67, 193);
            this.textBoxMdpEleve.Name = "textBoxMdpEleve";
            this.textBoxMdpEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxMdpEleve.TabIndex = 27;
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(237, 122);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomEleve.TabIndex = 26;
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(67, 122);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEleve.TabIndex = 25;
            // 
            // labelMdpProf
            // 
            this.labelMdpProf.AutoSize = true;
            this.labelMdpProf.Location = new System.Drawing.Point(26, 196);
            this.labelMdpProf.Name = "labelMdpProf";
            this.labelMdpProf.Size = new System.Drawing.Size(31, 13);
            this.labelMdpProf.TabIndex = 24;
            this.labelMdpProf.Text = "Mdp:";
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(183, 125);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomProf.TabIndex = 23;
            this.labelPrenomProf.Text = "Prenom :";
            // 
            // labelNomProf
            // 
            this.labelNomProf.AutoSize = true;
            this.labelNomProf.Location = new System.Drawing.Point(26, 125);
            this.labelNomProf.Name = "labelNomProf";
            this.labelNomProf.Size = new System.Drawing.Size(35, 13);
            this.labelNomProf.TabIndex = 22;
            this.labelNomProf.Text = "Nom :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(151, 25);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(84, 13);
            this.labelTitre.TabIndex = 21;
            this.labelTitre.Text = "Ajouter un eleve";
            // 
            // ajtEleveProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 371);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelMatiereProf);
            this.Controls.Add(this.buttonCreerEleve);
            this.Controls.Add(this.textBoxMdpEleve);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.textBoxNomEleve);
            this.Controls.Add(this.labelMdpProf);
            this.Controls.Add(this.labelPrenomProf);
            this.Controls.Add(this.labelNomProf);
            this.Controls.Add(this.labelTitre);
            this.Name = "ajtEleveProviseur";
            this.Text = "ajtEleveProviseur";
            this.Load += new System.EventHandler(this.ajtEleveProviseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMatiereProf;
        private System.Windows.Forms.Button buttonCreerEleve;
        private System.Windows.Forms.TextBox textBoxMdpEleve;
        private System.Windows.Forms.TextBox textBoxPrenomEleve;
        private System.Windows.Forms.TextBox textBoxNomEleve;
        private System.Windows.Forms.Label labelMdpProf;
        private System.Windows.Forms.Label labelPrenomProf;
        private System.Windows.Forms.Label labelNomProf;
        private System.Windows.Forms.Label labelTitre;
    }
}