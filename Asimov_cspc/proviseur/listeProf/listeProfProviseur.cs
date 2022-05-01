using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc
{
    public partial class listeProfProviseur : Form
    {
        Methodes m = new Methodes();
        public listeProfProviseur()
        {
            InitializeComponent();
        }

        private void buttonAjoutProf_Click(object sender, EventArgs e)
        {
            ajtProfProviseur ajtProfProviseur = new ajtProfProviseur();
            ajtProfProviseur.ShowDialog();

            dynamic newListe = m.getListeProfesseur();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListe.Count; i++)
            {
                dataGridView1.Rows.Add(newListe[i]["idProf"], newListe[i]["nom"], newListe[i]["prenom"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuProviseur menuProviseur = new menuProviseur();
            menuProviseur.Show();
            this.Hide();
        }

        private void listeProfProviseur_Load(object sender, EventArgs e)
        {
            //recuperation de la liste des professeur
            dynamic listeProfesseurs = m.getListeProfesseur();
            //affichage de la liste des professeurs
            if (listeProfesseurs != null)
            {
                for (int i = 0; i < listeProfesseurs.Count; i++)
                {

                    dataGridView1.Rows.Add(listeProfesseurs[i]["idProf"], listeProfesseurs[i]["nom"], listeProfesseurs[i]["prenom"]);
                }
            }
        }

        private void buttonDeleteMatiere_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //recupere l'id de la matiere (dans la cellule du dgv non visible)
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["idProf"].Value);
                MessageBox.Show(cellValue);

                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer ce professeur ?", "Securisation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m.deleteProfesseur(cellValue);
                    dataGridView1.CurrentRow.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recupere la ligne selectionner et les valeurs associé
            
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["idProf"].Value);
            string cellNom = selectedRow.Cells["NomProf"].Value.ToString();
            string cellPrenom = selectedRow.Cells["PrenomProf"].Value.ToString();

            MessageBox.Show(cellValue);

            //ouvre un form permettant la saisi des camps a modifier
            modifProfFormulaire modifProfFormulaire = new modifProfFormulaire(cellNom,cellPrenom, cellValue);
            modifProfFormulaire.ShowDialog();
            //affichage de la liste actualisé selon les modif réalisé
            
            dynamic newListeProf = m.getListeProfesseur();
            selectedRow.Visible = false;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListeProf.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { newListeProf[i]["idProf"],newListeProf[i]["nom"], newListeProf[i]["prenom"] });
            }
        }
    }
}
