namespace Asimov_cspc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPseudo = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonEleve = new System.Windows.Forms.RadioButton();
            this.radioButtonProf = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe:";
            // 
            // textBoxPseudo
            // 
            this.textBoxPseudo.Location = new System.Drawing.Point(145, 49);
            this.textBoxPseudo.Name = "textBoxPseudo";
            this.textBoxPseudo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPseudo.TabIndex = 2;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(145, 105);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(100, 20);
            this.textBoxPwd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonEleve
            // 
            this.radioButtonEleve.AutoSize = true;
            this.radioButtonEleve.Checked = true;
            this.radioButtonEleve.Location = new System.Drawing.Point(145, 146);
            this.radioButtonEleve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonEleve.Name = "radioButtonEleve";
            this.radioButtonEleve.Size = new System.Drawing.Size(86, 17);
            this.radioButtonEleve.TabIndex = 7;
            this.radioButtonEleve.TabStop = true;
            this.radioButtonEleve.Text = "Je suis eleve";
            this.radioButtonEleve.UseVisualStyleBackColor = true;
            // 
            // radioButtonProf
            // 
            this.radioButtonProf.AutoSize = true;
            this.radioButtonProf.Location = new System.Drawing.Point(145, 178);
            this.radioButtonProf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonProf.Name = "radioButtonProf";
            this.radioButtonProf.Size = new System.Drawing.Size(109, 17);
            this.radioButtonProf.TabIndex = 8;
            this.radioButtonProf.Text = "Je suis professeur";
            this.radioButtonProf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 296);
            this.Controls.Add(this.radioButtonProf);
            this.Controls.Add(this.radioButtonEleve);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxPseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPseudo;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonEleve;
        private System.Windows.Forms.RadioButton radioButtonProf;
    }
}

