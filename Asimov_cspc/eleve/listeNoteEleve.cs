using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc.eleve
{
    public partial class listeNoteEleve : Form
    {
        Methodes m = new Methodes();
        public listeNoteEleve()
        {
            InitializeComponent();
        }

        private void listeNoteEleve_Load(object sender, EventArgs e)
        {
            dynamic listeNote = m.getNoteEleve(Global.userInfo[0]["idEleve"].ToString());
            for (int i = 0; i < listeNote.Count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    listeNote[i]["idNote"],listeNote[i]["nom"] + " "+ listeNote[i]["prenom"],listeNote[i]["matiere"], listeNote[i]["Titre"], listeNote[i]["note"]

                });
            }

            dynamic listeMatiere = m.getListeMatiere();
            comboBox1.Items.Add(new ComboBoxItem("Afficher toutes les matieres", "0"));
            for (int i = 0; i < listeMatiere.Count; i++)
            {
                comboBox1.Items.Add(new ComboBoxItem(listeMatiere[i]["nom"], listeMatiere[i]["idMatiere"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idMatiere = ((ComboBoxItem)comboBox1.SelectedItem).HiddenValue.ToString();
            
            if (idMatiere == "0")
            {
                dynamic listeNote = m.getNoteEleve(Global.userInfo[0]["idEleve"].ToString());
                for (int i = 0; i < listeNote.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                    listeNote[i]["idNote"],listeNote[i]["nom"] + " "+ listeNote[i]["prenom"],listeNote[i]["matiere"], listeNote[i]["Titre"], listeNote[i]["note"]

                    });
                }
            }
            else
            {
                dynamic listeNoteMatiere = m.getNoteEleveMatiere(Global.userInfo[0]["idEleve"].ToString(), idMatiere);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < listeNoteMatiere.Count; i++)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        listeNoteMatiere[i]["idNote"],listeNoteMatiere[i]["nom"] + " "+ listeNoteMatiere[i]["prenom"],listeNoteMatiere[i]["matiere"], listeNoteMatiere[i]["Titre"], listeNoteMatiere[i]["note"]

                    });
                }    
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
