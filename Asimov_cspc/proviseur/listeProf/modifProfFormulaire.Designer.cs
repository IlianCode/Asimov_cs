namespace Asimov_cspc
{
    partial class modifProfFormulaire
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
            this.buttonModifProf = new System.Windows.Forms.Button();
            this.textBoxNomProf = new System.Windows.Forms.TextBox();
            this.labelNomProf = new System.Windows.Forms.Label();
            this.textBoxPrenomProf = new System.Windows.Forms.TextBox();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonModifProf
            // 
            this.buttonModifProf.Location = new System.Drawing.Point(317, 72);
            this.buttonModifProf.Name = "buttonModifProf";
            this.buttonModifProf.Size = new System.Drawing.Size(75, 23);
            this.buttonModifProf.TabIndex = 5;
            this.buttonModifProf.Text = "Modifier";
            this.buttonModifProf.UseVisualStyleBackColor = true;
            this.buttonModifProf.Click += new System.EventHandler(this.buttonModifProf_Click);
            // 
            // textBoxNomProf
            // 
            this.textBoxNomProf.Location = new System.Drawing.Point(53, 74);
            this.textBoxNomProf.Name = "textBoxNomProf";
            this.textBoxNomProf.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomProf.TabIndex = 4;
            // 
            // labelNomProf
            // 
            this.labelNomProf.AutoSize = true;
            this.labelNomProf.Location = new System.Drawing.Point(12, 77);
            this.labelNomProf.Name = "labelNomProf";
            this.labelNomProf.Size = new System.Drawing.Size(35, 13);
            this.labelNomProf.TabIndex = 3;
            this.labelNomProf.Text = "Nom: ";
            // 
            // textBoxPrenomProf
            // 
            this.textBoxPrenomProf.Location = new System.Drawing.Point(211, 74);
            this.textBoxPrenomProf.Name = "textBoxPrenomProf";
            this.textBoxPrenomProf.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomProf.TabIndex = 7;
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(156, 77);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomProf.TabIndex = 6;
            this.labelPrenomProf.Text = "Prenom: ";
            // 
            // modifProfFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 219);
            this.Controls.Add(this.textBoxPrenomProf);
            this.Controls.Add(this.labelPrenomProf);
            this.Controls.Add(this.buttonModifProf);
            this.Controls.Add(this.textBoxNomProf);
            this.Controls.Add(this.labelNomProf);
            this.Name = "modifProfFormulaire";
            this.Text = "modifProfFormulaire";
            this.Load += new System.EventHandler(this.modifProfFormulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifProf;
        private System.Windows.Forms.TextBox textBoxNomProf;
        private System.Windows.Forms.Label labelNomProf;
        private System.Windows.Forms.TextBox textBoxPrenomProf;
        private System.Windows.Forms.Label labelPrenomProf;
    }
}