namespace Asimov_cspc
{
    partial class listeNotesProviseur
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddMatiere = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatiereNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitreNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddMatiere
            // 
            this.buttonAddMatiere.Location = new System.Drawing.Point(276, 95);
            this.buttonAddMatiere.Name = "buttonAddMatiere";
            this.buttonAddMatiere.Size = new System.Drawing.Size(104, 23);
            this.buttonAddMatiere.TabIndex = 15;
            this.buttonAddMatiere.Text = "Ajouter une note";
            this.buttonAddMatiere.UseVisualStyleBackColor = true;
            this.buttonAddMatiere.Click += new System.EventHandler(this.buttonAddMatiere_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retour au menu proviseur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNote,
            this.NomEleve,
            this.PrenomEleve,
            this.MatiereNom,
            this.Note,
            this.TitreNote});
            this.dataGridView1.Location = new System.Drawing.Point(23, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 261);
            this.dataGridView1.TabIndex = 12;
            // 
            // idNote
            // 
            this.idNote.HeaderText = "idNote";
            this.idNote.Name = "idNote";
            this.idNote.ReadOnly = true;
            this.idNote.Visible = false;
            // 
            // NomEleve
            // 
            this.NomEleve.HeaderText = "NomEleve";
            this.NomEleve.Name = "NomEleve";
            this.NomEleve.ReadOnly = true;
            // 
            // PrenomEleve
            // 
            this.PrenomEleve.HeaderText = "PrenomEleve";
            this.PrenomEleve.Name = "PrenomEleve";
            this.PrenomEleve.ReadOnly = true;
            // 
            // MatiereNom
            // 
            this.MatiereNom.HeaderText = "MatiereNom";
            this.MatiereNom.Name = "MatiereNom";
            this.MatiereNom.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // TitreNote
            // 
            this.TitreNote.HeaderText = "TitreNote";
            this.TitreNote.Name = "TitreNote";
            this.TitreNote.ReadOnly = true;
            this.TitreNote.Width = 200;
            // 
            // buttonDeleteNote
            // 
            this.buttonDeleteNote.Location = new System.Drawing.Point(149, 95);
            this.buttonDeleteNote.Name = "buttonDeleteNote";
            this.buttonDeleteNote.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNote.TabIndex = 18;
            this.buttonDeleteNote.Text = "Supprimer";
            this.buttonDeleteNote.UseVisualStyleBackColor = true;
            this.buttonDeleteNote.Click += new System.EventHandler(this.buttonDeleteNote_Click);
            // 
            // listeNotesProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteNote);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddMatiere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeNotesProviseur";
            this.Text = "listeNotesProviseur";
            this.Load += new System.EventHandler(this.listeNotesProviseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddMatiere;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDeleteNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatiereNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreNote;
    }
}