using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc.proviseur.listeClasse
{
    public partial class listeClassesProviseur : Form
    {
        Methodes m = new Methodes();
        public listeClassesProviseur()
        {
            InitializeComponent();
        }

        private void listeClassesProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeClasse = m.getListeClasse();
            if (listeClasse != null)
            {

                for (int i = 0; i < listeClasse.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[] { listeClasse[i]["idClasse"], listeClasse[i]["nom"] });
                }
            }
        }

        private void buttonModifClasse_Click(object sender, EventArgs e)
        {
            //recupere la ligne selectionner et les valeurs associé

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["idClasse"].Value);
            string cellNom = selectedRow.Cells["NomClasse"].Value.ToString();

            MessageBox.Show(cellValue);

            //ouvre un form permettant la saisi des camps a modifier
            modifClasseProviseur modifClasseProviseur = new modifClasseProviseur(cellValue, cellNom);
            modifClasseProviseur.ShowDialog();

            dynamic newListeClasse = m.getListeClasse();
            selectedRow.Visible = false;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListeClasse.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { newListeClasse[i]["idClasse"], newListeClasse[i]["nom"] });
            }
        }

        private void buttonDeleteClasse_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //recupere l'id de la matiere (dans la cellule du dgv non visible)
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["idClasse"].Value) ;
                MessageBox.Show(cellValue);

                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer cette classe ?", "Securisation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m.deleteClasse(cellValue);
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

        private void buttonAjoutClasse_Click(object sender, EventArgs e)
        {
            ajtClasseProviseur ajtProviseur = new ajtClasseProviseur();
            ajtProviseur.ShowDialog();


            dynamic newListe = m.getListeClasse();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListe.Count; i++)
            {
                dataGridView1.Rows.Add(newListe[i]["idProf"], newListe[i]["nom"], newListe[i]["prenom"]);
            }

        }
    }
}
