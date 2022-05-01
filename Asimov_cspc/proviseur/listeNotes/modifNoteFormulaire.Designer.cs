namespace Asimov_cspc
{
    partial class modifNoteFormulaire
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
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.buttonModifProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(64, 51);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(100, 20);
            this.textBoxNote.TabIndex = 10;
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(9, 54);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(36, 13);
            this.labelPrenomProf.TabIndex = 9;
            this.labelPrenomProf.Text = "Note :";
            // 
            // buttonModifProf
            // 
            this.buttonModifProf.Location = new System.Drawing.Point(182, 49);
            this.buttonModifProf.Name = "buttonModifProf";
            this.buttonModifProf.Size = new System.Drawing.Size(75, 23);
            this.buttonModifProf.TabIndex = 8;
            this.buttonModifProf.Text = "Modifier";
            this.buttonModifProf.UseVisualStyleBackColor = true;
            this.buttonModifProf.Click += new System.EventHandler(this.buttonModifProf_Click);
            // 
            // modifNoteFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 114);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.labelPrenomProf);
            this.Controls.Add(this.buttonModifProf);
            this.Name = "modifNoteFormulaire";
            this.Text = "modifNoteFormulaire";
            this.Load += new System.EventHandler(this.modifNoteFormulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelPrenomProf;
        private System.Windows.Forms.Button buttonModifProf;
    }
}