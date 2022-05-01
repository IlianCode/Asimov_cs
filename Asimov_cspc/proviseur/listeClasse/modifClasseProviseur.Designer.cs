namespace Asimov_cspc.proviseur.listeClasse
{
    partial class modifClasseProviseur
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
            this.textBoxNomClasse = new System.Windows.Forms.TextBox();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.buttonModifClasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomClasse
            // 
            this.textBoxNomClasse.Location = new System.Drawing.Point(105, 42);
            this.textBoxNomClasse.Name = "textBoxNomClasse";
            this.textBoxNomClasse.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomClasse.TabIndex = 10;
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(50, 45);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomProf.TabIndex = 9;
            this.labelPrenomProf.Text = "Prenom: ";
            // 
            // buttonModifClasse
            // 
            this.buttonModifClasse.Location = new System.Drawing.Point(211, 40);
            this.buttonModifClasse.Name = "buttonModifClasse";
            this.buttonModifClasse.Size = new System.Drawing.Size(75, 23);
            this.buttonModifClasse.TabIndex = 8;
            this.buttonModifClasse.Text = "Modifier";
            this.buttonModifClasse.UseVisualStyleBackColor = true;
            this.buttonModifClasse.Click += new System.EventHandler(this.buttonModifClasse_Click);
            // 
            // modifClasseProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 120);
            this.Controls.Add(this.textBoxNomClasse);
            this.Controls.Add(this.labelPrenomProf);
            this.Controls.Add(this.buttonModifClasse);
            this.Name = "modifClasseProviseur";
            this.Text = "modifClasseProviseur";
            this.Load += new System.EventHandler(this.modifClasseProviseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomClasse;
        private System.Windows.Forms.Label labelPrenomProf;
        private System.Windows.Forms.Button buttonModifClasse;
    }
}