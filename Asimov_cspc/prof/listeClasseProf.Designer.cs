namespace Asimov_cspc
{
    partial class listeClasseProf
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
            this.components = new System.ComponentModel.Container();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NomDeClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsClasse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.listeClasseProfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeClasseProfBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(257, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(126, 66);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Se deconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomDeClasse,
            this.DetailsClasse});
            this.dataGridView1.Location = new System.Drawing.Point(69, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(314, 269);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomDeClasse
            // 
            this.NomDeClasse.HeaderText = "NomDeClasse";
            this.NomDeClasse.MinimumWidth = 6;
            this.NomDeClasse.Name = "NomDeClasse";
            this.NomDeClasse.ReadOnly = true;
            this.NomDeClasse.Width = 125;
            // 
            // DetailsClasse
            // 
            this.DetailsClasse.HeaderText = "DetailsClasse";
            this.DetailsClasse.MinimumWidth = 6;
            this.DetailsClasse.Name = "DetailsClasse";
            this.DetailsClasse.Width = 125;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // listeClasseProfBindingSource
            // 
            this.listeClasseProfBindingSource.DataSource = typeof(Asimov_cspc.listeClasseProf);
            // 
            // listeClasseProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeconnexion);
            this.Name = "listeClasseProf";
            this.Text = "listeClasseProf";
            this.Load += new System.EventHandler(this.listeClasseProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeClasseProfBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listeClasseProfBindingSource;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomDeClasse;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsClasse;
    }
}