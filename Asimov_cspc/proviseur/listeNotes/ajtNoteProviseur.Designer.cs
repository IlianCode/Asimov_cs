namespace Asimov_cspc
{
    partial class ajtNoteProviseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMatiere = new System.Windows.Forms.ComboBox();
            this.comboBoxEleve = new System.Windows.Forms.ComboBox();
            this.textBoxIntitule = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonAjouterNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matiere: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eleve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intitulé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note/100: ";
            // 
            // comboBoxMatiere
            // 
            this.comboBoxMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatiere.FormattingEnabled = true;
            this.comboBoxMatiere.Location = new System.Drawing.Point(105, 53);
            this.comboBoxMatiere.Name = "comboBoxMatiere";
            this.comboBoxMatiere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMatiere.TabIndex = 5;
            // 
            // comboBoxEleve
            // 
            this.comboBoxEleve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEleve.FormattingEnabled = true;
            this.comboBoxEleve.Location = new System.Drawing.Point(105, 91);
            this.comboBoxEleve.Name = "comboBoxEleve";
            this.comboBoxEleve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEleve.TabIndex = 6;
            // 
            // textBoxIntitule
            // 
            this.textBoxIntitule.Location = new System.Drawing.Point(105, 136);
            this.textBoxIntitule.Name = "textBoxIntitule";
            this.textBoxIntitule.Size = new System.Drawing.Size(155, 20);
            this.textBoxIntitule.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(117, 198);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(100, 20);
            this.textBoxNote.TabIndex = 9;
            // 
            // buttonAjouterNote
            // 
            this.buttonAjouterNote.Location = new System.Drawing.Point(129, 252);
            this.buttonAjouterNote.Name = "buttonAjouterNote";
            this.buttonAjouterNote.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterNote.TabIndex = 10;
            this.buttonAjouterNote.Text = "button1";
            this.buttonAjouterNote.UseVisualStyleBackColor = true;
            this.buttonAjouterNote.Click += new System.EventHandler(this.buttonAjouterNote_Click);
            // 
            // ajtNoteProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.buttonAjouterNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxIntitule);
            this.Controls.Add(this.comboBoxEleve);
            this.Controls.Add(this.comboBoxMatiere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ajtNoteProviseur";
            this.Text = "ajtNoteProviseur";
            this.Load += new System.EventHandler(this.ajtNoteProviseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMatiere;
        private System.Windows.Forms.ComboBox comboBoxEleve;
        private System.Windows.Forms.TextBox textBoxIntitule;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonAjouterNote;
    }
}