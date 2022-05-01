namespace Asimov_cspc.proviseur.listeEleves
{
    partial class listeElevesProviseur
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
            this.idEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.buttonAjouterEleve = new System.Windows.Forms.Button();
            this.buttonDeleteEleve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEleve,
            this.NomEleve,
            this.PrenomEleve,
            this.NomClasse});
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // idEleve
            // 
            this.idEleve.HeaderText = "idEleve";
            this.idEleve.Name = "idEleve";
            this.idEleve.ReadOnly = true;
            this.idEleve.Visible = false;
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
            // NomClasse
            // 
            this.NomClasse.HeaderText = "NomClasse";
            this.NomClasse.Name = "NomClasse";
            this.NomClasse.ReadOnly = true;
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(40, 85);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierEleve.TabIndex = 1;
            this.buttonModifierEleve.Text = "Modifier";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            this.buttonModifierEleve.Click += new System.EventHandler(this.buttonModifierEleve_Click);
            // 
            // buttonAjouterEleve
            // 
            this.buttonAjouterEleve.Location = new System.Drawing.Point(161, 85);
            this.buttonAjouterEleve.Name = "buttonAjouterEleve";
            this.buttonAjouterEleve.Size = new System.Drawing.Size(96, 23);
            this.buttonAjouterEleve.TabIndex = 2;
            this.buttonAjouterEleve.Text = "Ajouter eleve ";
            this.buttonAjouterEleve.UseVisualStyleBackColor = true;
            this.buttonAjouterEleve.Click += new System.EventHandler(this.buttonAjouterEleve_Click);
            // 
            // buttonDeleteEleve
            // 
            this.buttonDeleteEleve.Location = new System.Drawing.Point(296, 85);
            this.buttonDeleteEleve.Name = "buttonDeleteEleve";
            this.buttonDeleteEleve.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteEleve.TabIndex = 3;
            this.buttonDeleteEleve.Text = "Supprimer eleve";
            this.buttonDeleteEleve.UseVisualStyleBackColor = true;
            this.buttonDeleteEleve.Click += new System.EventHandler(this.buttonDeleteEleve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Retour au menu proviseur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeElevesProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDeleteEleve);
            this.Controls.Add(this.buttonAjouterEleve);
            this.Controls.Add(this.buttonModifierEleve);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeElevesProviseur";
            this.Text = "listeElevesProviseur";
            this.Load += new System.EventHandler(this.listeElevesProviseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClasse;
        private System.Windows.Forms.Button buttonModifierEleve;
        private System.Windows.Forms.Button buttonAjouterEleve;
        private System.Windows.Forms.Button buttonDeleteEleve;
        private System.Windows.Forms.Button button1;
    }
}