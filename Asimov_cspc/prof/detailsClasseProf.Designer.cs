namespace Asimov_cspc
{
    partial class detailsClasseProf
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
            this.NomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEleve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoirNotesEleve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.labelNomEleve = new System.Windows.Forms.Label();
            this.labelPrenomEleve = new System.Windows.Forms.Label();
            this.labelMdpEleve = new System.Windows.Forms.Label();
            this.textBoxNomEleve = new System.Windows.Forms.TextBox();
            this.textBoxPrenomEleve = new System.Windows.Forms.TextBox();
            this.textBoxMdpEleve = new System.Windows.Forms.TextBox();
            this.buttonCreerEleve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomEleve,
            this.PrenomEleve,
            this.VoirNotesEleve});
            this.dataGridView1.Location = new System.Drawing.Point(35, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 257);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NomEleve
            // 
            this.NomEleve.HeaderText = "Nom";
            this.NomEleve.MinimumWidth = 6;
            this.NomEleve.Name = "NomEleve";
            this.NomEleve.ReadOnly = true;
            this.NomEleve.Width = 125;
            // 
            // PrenomEleve
            // 
            this.PrenomEleve.HeaderText = "PrenomEleve";
            this.PrenomEleve.MinimumWidth = 6;
            this.PrenomEleve.Name = "PrenomEleve";
            this.PrenomEleve.ReadOnly = true;
            this.PrenomEleve.Width = 125;
            // 
            // VoirNotesEleve
            // 
            this.VoirNotesEleve.HeaderText = "VoirNotesEleve";
            this.VoirNotesEleve.MinimumWidth = 6;
            this.VoirNotesEleve.Name = "VoirNotesEleve";
            this.VoirNotesEleve.ReadOnly = true;
            this.VoirNotesEleve.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "Retourner a la liste de classe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(586, 59);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(126, 66);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Se deconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // labelNomEleve
            // 
            this.labelNomEleve.AutoSize = true;
            this.labelNomEleve.Location = new System.Drawing.Point(20, 337);
            this.labelNomEleve.Name = "labelNomEleve";
            this.labelNomEleve.Size = new System.Drawing.Size(35, 13);
            this.labelNomEleve.TabIndex = 4;
            this.labelNomEleve.Text = "Nom :";
            // 
            // labelPrenomEleve
            // 
            this.labelPrenomEleve.AutoSize = true;
            this.labelPrenomEleve.Location = new System.Drawing.Point(177, 337);
            this.labelPrenomEleve.Name = "labelPrenomEleve";
            this.labelPrenomEleve.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomEleve.TabIndex = 5;
            this.labelPrenomEleve.Text = "Prenom :";
            // 
            // labelMdpEleve
            // 
            this.labelMdpEleve.AutoSize = true;
            this.labelMdpEleve.Location = new System.Drawing.Point(337, 337);
            this.labelMdpEleve.Name = "labelMdpEleve";
            this.labelMdpEleve.Size = new System.Drawing.Size(31, 13);
            this.labelMdpEleve.TabIndex = 6;
            this.labelMdpEleve.Text = "Mdp:";
            // 
            // textBoxNomEleve
            // 
            this.textBoxNomEleve.Location = new System.Drawing.Point(61, 334);
            this.textBoxNomEleve.Name = "textBoxNomEleve";
            this.textBoxNomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEleve.TabIndex = 7;
            // 
            // textBoxPrenomEleve
            // 
            this.textBoxPrenomEleve.Location = new System.Drawing.Point(231, 334);
            this.textBoxPrenomEleve.Name = "textBoxPrenomEleve";
            this.textBoxPrenomEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomEleve.TabIndex = 8;
            // 
            // textBoxMdpEleve
            // 
            this.textBoxMdpEleve.Location = new System.Drawing.Point(378, 334);
            this.textBoxMdpEleve.Name = "textBoxMdpEleve";
            this.textBoxMdpEleve.Size = new System.Drawing.Size(100, 20);
            this.textBoxMdpEleve.TabIndex = 9;
            // 
            // buttonCreerEleve
            // 
            this.buttonCreerEleve.Location = new System.Drawing.Point(499, 332);
            this.buttonCreerEleve.Name = "buttonCreerEleve";
            this.buttonCreerEleve.Size = new System.Drawing.Size(87, 23);
            this.buttonCreerEleve.TabIndex = 10;
            this.buttonCreerEleve.Text = "Créer nouvel eleve";
            this.buttonCreerEleve.UseVisualStyleBackColor = true;
            this.buttonCreerEleve.Click += new System.EventHandler(this.buttonCreerEleve_Click);
            // 
            // detailsClasseProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 366);
            this.Controls.Add(this.buttonCreerEleve);
            this.Controls.Add(this.textBoxMdpEleve);
            this.Controls.Add(this.textBoxPrenomEleve);
            this.Controls.Add(this.textBoxNomEleve);
            this.Controls.Add(this.labelMdpEleve);
            this.Controls.Add(this.labelPrenomEleve);
            this.Controls.Add(this.labelNomEleve);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "detailsClasseProf";
            this.Text = "detailsClasseProf";
            this.Load += new System.EventHandler(this.detailsClasseProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEleve;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEleve;
        private System.Windows.Forms.DataGridViewButtonColumn VoirNotesEleve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label labelNomEleve;
        private System.Windows.Forms.Label labelPrenomEleve;
        private System.Windows.Forms.Label labelMdpEleve;
        private System.Windows.Forms.TextBox textBoxNomEleve;
        private System.Windows.Forms.TextBox textBoxPrenomEleve;
        private System.Windows.Forms.TextBox textBoxMdpEleve;
        private System.Windows.Forms.Button buttonCreerEleve;
    }
}