namespace Asimov_cspc
{
    partial class listeProfProviseur
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
            this.buttonDeleteMatiere = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAjoutProf = new System.Windows.Forms.Button();
            this.idProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteMatiere
            // 
            this.buttonDeleteMatiere.Location = new System.Drawing.Point(139, 118);
            this.buttonDeleteMatiere.Name = "buttonDeleteMatiere";
            this.buttonDeleteMatiere.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMatiere.TabIndex = 18;
            this.buttonDeleteMatiere.Text = "Supprimer";
            this.buttonDeleteMatiere.UseVisualStyleBackColor = true;
            this.buttonDeleteMatiere.Click += new System.EventHandler(this.buttonDeleteMatiere_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 41);
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
            this.idProf,
            this.NomProf,
            this.PrenomProf});
            this.dataGridView1.Location = new System.Drawing.Point(47, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // buttonAjoutProf
            // 
            this.buttonAjoutProf.Location = new System.Drawing.Point(233, 118);
            this.buttonAjoutProf.Name = "buttonAjoutProf";
            this.buttonAjoutProf.Size = new System.Drawing.Size(75, 23);
            this.buttonAjoutProf.TabIndex = 19;
            this.buttonAjoutProf.Text = "Ajouter ";
            this.buttonAjoutProf.UseVisualStyleBackColor = true;
            this.buttonAjoutProf.Click += new System.EventHandler(this.buttonAjoutProf_Click);
            // 
            // idProf
            // 
            this.idProf.HeaderText = "idProf";
            this.idProf.Name = "idProf";
            this.idProf.ReadOnly = true;
            this.idProf.Visible = false;
            // 
            // NomProf
            // 
            this.NomProf.HeaderText = "NomProf";
            this.NomProf.Name = "NomProf";
            this.NomProf.ReadOnly = true;
            // 
            // PrenomProf
            // 
            this.PrenomProf.HeaderText = "PrenomProf";
            this.PrenomProf.Name = "PrenomProf";
            this.PrenomProf.ReadOnly = true;
            // 
            // listeProfProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 408);
            this.Controls.Add(this.buttonAjoutProf);
            this.Controls.Add(this.buttonDeleteMatiere);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeProfProviseur";
            this.Text = "listeProfProviseur";
            this.Load += new System.EventHandler(this.listeProfProviseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteMatiere;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAjoutProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomProf;
    }
}