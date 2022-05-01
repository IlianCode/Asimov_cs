namespace Asimov_cspc
{
    partial class listeNotesEleveMatiere
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitreNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteNote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxTitreNote = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.labelTitreNote = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitreNote,
            this.Note,
            this.DeleteNote});
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TitreNote
            // 
            this.TitreNote.HeaderText = "TitreNote";
            this.TitreNote.Name = "TitreNote";
            this.TitreNote.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // DeleteNote
            // 
            this.DeleteNote.HeaderText = "DeleteNote";
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.ReadOnly = true;
            // 
            // textBoxTitreNote
            // 
            this.textBoxTitreNote.Location = new System.Drawing.Point(98, 338);
            this.textBoxTitreNote.Name = "textBoxTitreNote";
            this.textBoxTitreNote.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitreNote.TabIndex = 1;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(283, 338);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(100, 20);
            this.textBoxNote.TabIndex = 2;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(414, 335);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(93, 23);
            this.buttonAddNote.TabIndex = 3;
            this.buttonAddNote.Text = "Ajouter la note";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            this.buttonAddNote.Click += new System.EventHandler(this.buttonAddNote_Click);
            // 
            // labelTitreNote
            // 
            this.labelTitreNote.AutoSize = true;
            this.labelTitreNote.Location = new System.Drawing.Point(1, 341);
            this.labelTitreNote.Name = "labelTitreNote";
            this.labelTitreNote.Size = new System.Drawing.Size(91, 13);
            this.labelTitreNote.TabIndex = 4;
            this.labelTitreNote.Text = "Intitulé de la note:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(221, 341);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(56, 13);
            this.labelNote.TabIndex = 5;
            this.labelNote.Text = "Note/20 : ";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(656, 30);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(126, 66);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Se deconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Retourner a la liste de classe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 75);
            this.button2.TabIndex = 8;
            this.button2.Text = "Retourner a la liste des eleves";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listeNotesEleveMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelTitreNote);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxTitreNote);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeNotesEleveMatiere";
            this.Text = "listeNotesEleveMatiere";
            this.Load += new System.EventHandler(this.listeNotesEleveMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitreNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteNote;
        private System.Windows.Forms.TextBox textBoxTitreNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Label labelTitreNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}