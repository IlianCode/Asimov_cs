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
    public partial class listeNotesProviseur : Form
    {
        Methodes m = new Methodes();
        public listeNotesProviseur()
        {
            InitializeComponent();
        }

        private void listeNotesProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeNote = m.getNotes();
            if (listeNote != null)
            {

                for (int i = 0; i < listeNote.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[] { listeNote[i]["idNote"], listeNote[i]["nomEleve"], listeNote[i]["prenom"],
                    listeNote[i]["nom"],listeNote[i]["note"],listeNote[i]["Titre"]});
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuProviseur menuProviseur = new menuProviseur();
            menuProviseur.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["idNote"].Value);
            string cellNote = selectedRow.Cells["note"].Value.ToString();
            MessageBox.Show(cellNote);

            modifNoteFormulaire modifNoteFormulaire = new modifNoteFormulaire(cellValue, cellNote);
            modifNoteFormulaire.ShowDialog();

            dynamic newListeNotes = m.getNotes();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListeNotes.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { newListeNotes[i]["idNote"], newListeNotes[i]["nomEleve"], newListeNotes[i]["prenom"],
                    newListeNotes[i]["nom"],newListeNotes[i]["note"],newListeNotes[i]["Titre"]});
            }
        }

        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //recupere l'id de la matiere (dans la cellule du dgv non visible)
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["idNote"].Value);
                MessageBox.Show(cellValue);

                DialogResult dialogResult = MessageBox.Show("Êtes vous sur de vouloir supprimer cette matiere ?", "Securisation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m.deleteNote(cellValue);
                    dataGridView1.CurrentRow.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                }


            }
        }

        private void buttonAddMatiere_Click(object sender, EventArgs e)
        {
            ajtNoteProviseur ajtNoteProviseur = new ajtNoteProviseur();
            ajtNoteProviseur.ShowDialog();
            this.Hide();

            dynamic newListeNotes = m.getNotes();

            dataGridView1.Rows.Clear();
            for (int i = 0; i < newListeNotes.Count; i++)
            {
                dataGridView1.Rows.Add(new object[] { newListeNotes[i]["idNote"], newListeNotes[i]["nomEleve"], newListeNotes[i]["prenom"],
                    newListeNotes[i]["nom"],newListeNotes[i]["note"],newListeNotes[i]["Titre"]});
            }
        }
    }
}
