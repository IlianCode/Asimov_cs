using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc.proviseur.listeEleves
{
    public partial class listeElevesProviseur : Form
    {
        Methodes m = new Methodes();
        public listeElevesProviseur()
        {
            InitializeComponent();
        }

        private void listeElevesProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeEleves = m.getListeElevesProviseur();
            if (listeEleves != null)
            {
                for (int i = 0; i < listeEleves.Count; i++)
                {

                    dataGridView1.Rows.Add(listeEleves[i]["idEleve"], listeEleves[i]["nomEleve"], listeEleves[i]["prenom"], listeEleves[i]["nomClasse"]);
                }
            }
        }

        private void buttonDeleteEleve_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //recupere l'id de la matiere (dans la cellule du dgv non visible)
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["idEleve"].Value);
                MessageBox.Show(cellValue);

                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer ce professeur ?", "Securisation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m.deleteEleve(cellValue);
                    dataGridView1.CurrentRow.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuProviseur menuProviseur = new menuProviseur();
            menuProviseur.Show();
            this.Hide();
        }

        private void buttonModifierEleve_Click(object sender, EventArgs e)
        {
            //recupere la ligne selectionner et les valeurs associé

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = selectedRow.Cells["idEleve"].Value.ToString();
            string cellNom = selectedRow.Cells["NomEleve"].Value.ToString();
            string cellPrenom = selectedRow.Cells["PrenomEleve"].Value.ToString();
            string cellNomClasse = selectedRow.Cells["NomClasse"].Value.ToString();

            MessageBox.Show(cellValue);

            //ouvre un form permettant la saisi des camps a modifier
            modifEleveProviseur modifEleveProviseur = new modifEleveProviseur(cellValue, cellNom, cellPrenom,cellNomClasse) ;
            modifEleveProviseur.ShowDialog();
            //affichage de la liste actualisé selon les modif réalisé

            dynamic newListeEleve = m.getListeElevesProviseur();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListeEleve.Count; i++)
            {

                dataGridView1.Rows.Add(newListeEleve[i]["idEleve"], newListeEleve[i]["nomEleve"], newListeEleve[i]["prenom"], newListeEleve[i]["nomClasse"]);
            }
            
            
        }

        private void buttonAjouterEleve_Click(object sender, EventArgs e)
        {
            ajtEleveProviseur ajtEleveProviseur = new ajtEleveProviseur();
            ajtEleveProviseur.ShowDialog();

            dynamic newListe = m.getListeElevesProviseur();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListe.Count; i++)
            {

                dataGridView1.Rows.Add(newListe[i]["idEleve"], newListe[i]["nomEleve"], newListe[i]["prenom"], newListe[i]["nomClasse"]);
            }
        }
    }
}
