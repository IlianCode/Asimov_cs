namespace Asimov_cspc.proviseur.listeEleves
{
    partial class modifEleveProviseur
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
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.buttonModifProf = new System.Windows.Forms.Button();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.labelNomProf = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(111, 99);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomEleve.TabIndex = 11;
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(49, 106);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomProf.TabIndex = 10;
            this.labelPrenomProf.Text = "Prenom: ";
            // 
            // buttonModifProf
            // 
            this.buttonModifProf.Location = new System.Drawing.Point(136, 206);
            this.buttonModifProf.Name = "buttonModifProf";
            this.buttonModifProf.Size = new System.Drawing.Size(75, 23);
            this.buttonModifProf.TabIndex = 9;
            this.buttonModifProf.Text = "Modifier";
            this.buttonModifProf.UseVisualStyleBackColor = true;
            this.buttonModifProf.Click += new System.EventHandler(this.buttonModifProf_Click);
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(111, 58);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEleve.TabIndex = 8;
            // 
            // labelNomProf
            // 
            this.labelNomProf.AutoSize = true;
            this.labelNomProf.Location = new System.Drawing.Point(49, 65);
            this.labelNomProf.Name = "labelNomProf";
            this.labelNomProf.Size = new System.Drawing.Size(35, 13);
            this.labelNomProf.TabIndex = 12;
            this.labelNomProf.Text = "Nom: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Classe";
            // 
            // modifEleveProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelNomProf);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.labelPrenomProf);
            this.Controls.Add(this.buttonModifProf);
            this.Controls.Add(this.textBoxNomEleve);
            this.Name = "modifEleveProviseur";
            this.Text = "modifEleveProviseur";
            this.Load += new System.EventHandler(this.modifEleveProviseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrenomEleve;
        private System.Windows.Forms.Label labelPrenomProf;
        private System.Windows.Forms.Button buttonModifProf;
        private System.Windows.Forms.TextBox textBoxNomEleve;
        private System.Windows.Forms.Label labelNomProf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}