using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc
{
    public partial class listeMatiereProviseur : Form
    {
        Methodes m = new Methodes();
        public listeMatiereProviseur()
        {
            InitializeComponent();
        }

        private void listeMatiereProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeClasse = m.getListeClasse();
            if (listeClasse != null)
            {

                for (int i = 0; i < listeClasse.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[]{ listeClasse[i]["idClasse"], listeClasse[i]["nom"]});
                }
            }
        }

        private void buttonAddMatiere_Click(object sender, EventArgs e)
        {
            string txtBoxNomMatiere = textBoxNomMatiere.Text;
            m.createMatiere(txtBoxNomMatiere);
            dynamic newListe = m.getListeMatiere();
            int taille = newListe.Count;
            taille--;

            dataGridView1.Rows.Add(new object[]
                {
                    newListe[taille]["nom"],  newListe[taille]["idMatiere"]

                });
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //retour au menuProviseur
            menuProviseur menuProviseur = new menuProviseur();
            menuProviseur.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["idMatiere"].Value);
            string cellNom = selectedRow.Cells["NomMatiere"].Value.ToString();
            MessageBox.Show(cellValue);


            modifFormulaire modifFormulaire = new modifFormulaire(cellNom, cellValue);
            modifFormulaire.ShowDialog();
            dynamic newListe = m.getListeMatiere();

            selectedRow.Visible = false;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListe.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { newListe[i]["nom"], newListe[i]["idMatiere"] });
            }            

        }

        private void buttonDeleteMatiere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //recupere l'id de la matiere (dans la cellule du dgv non visible)
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["idMatiere"].Value);
                MessageBox.Show(cellValue);

                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer cette matiere ?", "Securisation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m.deleteMatiere(cellValue);
                    dataGridView1.CurrentRow.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                

            }                          
        }

       
    }
}

