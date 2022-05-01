namespace Asimov_cspc.proviseur.listeClasse
{
    partial class listeClassesProviseur
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
            this.buttonAjoutClasse = new System.Windows.Forms.Button();
            this.buttonDeleteClasse = new System.Windows.Forms.Button();
            this.buttonModifClasse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAjoutClasse
            // 
            this.buttonAjoutClasse.Location = new System.Drawing.Point(208, 89);
            this.buttonAjoutClasse.Name = "buttonAjoutClasse";
            this.buttonAjoutClasse.Size = new System.Drawing.Size(75, 23);
            this.buttonAjoutClasse.TabIndex = 24;
            this.buttonAjoutClasse.Text = "Ajouter ";
            this.buttonAjoutClasse.UseVisualStyleBackColor = true;
            this.buttonAjoutClasse.Click += new System.EventHandler(this.buttonAjoutClasse_Click);
            // 
            // buttonDeleteClasse
            // 
            this.buttonDeleteClasse.Location = new System.Drawing.Point(114, 89);
            this.buttonDeleteClasse.Name = "buttonDeleteClasse";
            this.buttonDeleteClasse.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteClasse.TabIndex = 23;
            this.buttonDeleteClasse.Text = "Supprimer";
            this.buttonDeleteClasse.UseVisualStyleBackColor = true;
            this.buttonDeleteClasse.Click += new System.EventHandler(this.buttonDeleteClasse_Click);
            // 
            // buttonModifClasse
            // 
            this.buttonModifClasse.Location = new System.Drawing.Point(22, 89);
            this.buttonModifClasse.Name = "buttonModifClasse";
            this.buttonModifClasse.Size = new System.Drawing.Size(75, 23);
            this.buttonModifClasse.TabIndex = 22;
            this.buttonModifClasse.Text = "Modifier";
            this.buttonModifClasse.UseVisualStyleBackColor = true;
            this.buttonModifClasse.Click += new System.EventHandler(this.buttonModifClasse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Retour au menu proviseur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasse,
            this.NomClasse});
            this.dataGridView1.Location = new System.Drawing.Point(22, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // idClasse
            // 
            this.idClasse.HeaderText = "idClasse";
            this.idClasse.Name = "idClasse";
            this.idClasse.ReadOnly = true;
            this.idClasse.Visible = false;
            // 
            // NomClasse
            // 
            this.NomClasse.HeaderText = "NomClasse";
            this.NomClasse.Name = "NomClasse";
            this.NomClasse.ReadOnly = true;
            // 
            // listeClassesProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.buttonAjoutClasse);
            this.Controls.Add(this.buttonDeleteClasse);
            this.Controls.Add(this.buttonModifClasse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeClassesProviseur";
            this.Text = "listeClassesProviseur";
            this.Load += new System.EventHandler(this.listeClassesProviseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAjoutClasse;
        private System.Windows.Forms.Button buttonDeleteClasse;
        private System.Windows.Forms.Button buttonModifClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClasse;
    }
}