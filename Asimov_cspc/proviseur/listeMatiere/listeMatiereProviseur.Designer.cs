namespace Asimov_cspc
{
    partial class listeMatiereProviseur
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
            this.NomMatiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMatiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNomMatiere = new System.Windows.Forms.Label();
            this.buttonAddMatiere = new System.Windows.Forms.Button();
            this.textBoxNomMatiere = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteMatiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomMatiere,
            this.IdMatiere});
            this.dataGridView1.Location = new System.Drawing.Point(94, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(233, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // NomMatiere
            // 
            this.NomMatiere.HeaderText = "NomMatiere";
            this.NomMatiere.Name = "NomMatiere";
            this.NomMatiere.ReadOnly = true;
            // 
            // IdMatiere
            // 
            this.IdMatiere.HeaderText = "IdMatiere";
            this.IdMatiere.Name = "IdMatiere";
            this.IdMatiere.ReadOnly = true;
            this.IdMatiere.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour au menu proviseur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNomMatiere
            // 
            this.labelNomMatiere.AutoSize = true;
            this.labelNomMatiere.Location = new System.Drawing.Point(78, 364);
            this.labelNomMatiere.Name = "labelNomMatiere";
            this.labelNomMatiere.Size = new System.Drawing.Size(101, 13);
            this.labelNomMatiere.TabIndex = 9;
            this.labelNomMatiere.Text = "Nom de la matiere : ";
            // 
            // buttonAddMatiere
            // 
            this.buttonAddMatiere.Location = new System.Drawing.Point(301, 359);
            this.buttonAddMatiere.Name = "buttonAddMatiere";
            this.buttonAddMatiere.Size = new System.Drawing.Size(104, 23);
            this.buttonAddMatiere.TabIndex = 8;
            this.buttonAddMatiere.Text = "Ajout de la matiere";
            this.buttonAddMatiere.UseVisualStyleBackColor = true;
            this.buttonAddMatiere.Click += new System.EventHandler(this.buttonAddMatiere_Click);
            // 
            // textBoxNomMatiere
            // 
            this.textBoxNomMatiere.Location = new System.Drawing.Point(185, 361);
            this.textBoxNomMatiere.Name = "textBoxNomMatiere";
            this.textBoxNomMatiere.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomMatiere.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeleteMatiere
            // 
            this.buttonDeleteMatiere.Location = new System.Drawing.Point(165, 97);
            this.buttonDeleteMatiere.Name = "buttonDeleteMatiere";
            this.buttonDeleteMatiere.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMatiere.TabIndex = 11;
            this.buttonDeleteMatiere.Text = "Supprimer";
            this.buttonDeleteMatiere.UseVisualStyleBackColor = true;
            this.buttonDeleteMatiere.Click += new System.EventHandler(this.buttonDeleteMatiere_Click);
            // 
            // listeMatiereProviseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.buttonDeleteMatiere);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelNomMatiere);
            this.Controls.Add(this.buttonAddMatiere);
            this.Controls.Add(this.textBoxNomMatiere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeMatiereProviseur";
            this.Text = "listeMatiereProviseur";
            this.Load += new System.EventHandler(this.listeMatiereProviseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNomMatiere;
        private System.Windows.Forms.Button buttonAddMatiere;
        private System.Windows.Forms.TextBox textBoxNomMatiere;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteMatiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMatiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMatiere;
    }
}