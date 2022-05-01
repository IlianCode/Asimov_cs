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
    public partial class ajtNoteProviseur : Form
    {
        Methodes m = new Methodes();
        public ajtNoteProviseur()
        {
            InitializeComponent();
        }

        private void ajtNoteProviseur_Load(object sender, EventArgs e)
        {
            //remplissage de la combo box eleve
            dynamic listeEleve = m.getEleves();
            for (int i = 0; i < listeEleve.Count; i++)
            {
                comboBoxEleve.Items.Add(new ComboBoxItem(listeEleve[i]["nom"]+" " + listeEleve[i]["prenom"], listeEleve[i]["idEleve"]));
            }
            //remplissage de la combobox matiere
            dynamic listeMatiere = m.getListeMatiere();
            for (int i = 0; i < listeMatiere.Count; i++)
            {
                comboBoxMatiere.Items.Add(new ComboBoxItem(listeMatiere[i]["nom"], listeMatiere[i]["idMatiere"]));
            }
        }

        private void buttonAjouterNote_Click(object sender, EventArgs e)
        {
            string idMatiere = ((ComboBoxItem)comboBoxMatiere.SelectedItem).HiddenValue.ToString();
            string idEleve = ((ComboBoxItem)comboBoxEleve.SelectedItem).HiddenValue.ToString();
            string intitule = textBoxIntitule.Text;
            string note = textBoxNote.Text;
            DateTime dateTimePicker = dateTimePicker1.Value;
            string sqlFormattedDate = dateTimePicker.ToString("yyyy-MM-dd");

            //creation d'une note avec l'api
            string url = "http://localhost:3001/asimov/api/Ajout_Notes_Date/"+ idEleve + "/"+idMatiere+"/"+note+"/"+ sqlFormattedDate + "/"+ intitule;
            String json = new WebClient().DownloadString(url);
            this.Close();

        }
    }
   

}
