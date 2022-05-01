using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace Asimov_cspc
{
    public partial class listeNotesEleveMatiere : Form
    {
        public listeNotesEleveMatiere()
        {
            InitializeComponent();
        }
        public dynamic getNoteEleve()
        {
            string idProf = Global.userInfo[0]["idProf"].ToString();
            string idEleve = Global.lastEleveChose.ToString();
            string url = "http://localhost:3001/asimov/api/Notes_Matiere/" + idProf + "/" + idEleve;
            MessageBox.Show(url);
            String json = new WebClient().DownloadString(url);
            MessageBox.Show(json);
            if (json !="")
            {
                dynamic listeNoteEleve = JsonConvert.DeserializeObject<dynamic>(json);
                return listeNoteEleve;

            }
            return json;
        }
        private void listeNotesEleveMatiere_Load(object sender, EventArgs e)
        {
            dynamic liste = getNoteEleve();
            MessageBox.Show(liste.ToString());
            if( liste is string == false)
            {
                if (liste.Count > 0)
                {
                    for (int i = 0; i < liste.Count; i++)
                    {
                        dataGridView1.Rows.Add(new object[]
                        {
                    liste[i]["Titre"],liste[i]["note"], DeleteNote.Text = liste[i]["idNote"]

                        });


                    }
                }
            }
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = "http://localhost:3001/asimov/api/Suppr_Notes_Matiere/" + dataGridView1.CurrentCell.Value.ToString();
            String json = new WebClient().DownloadString(url);
            dataGridView1.CurrentRow.Visible = false;
        }

        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            String txtBoxTitreNote = textBoxTitreNote.Text;
            String txtBoxNote = textBoxNote.Text;
            string url = "http://localhost:3001/asimov/api/Ajout_Notes_Matiere/" + Global.userInfo[0]["Id_Matiere"] + "/" + Global.lastEleveChose + "/" + txtBoxTitreNote + "/" + txtBoxNote;
            String json = new WebClient().DownloadString(url);

            dynamic newListe = getNoteEleve();
            int taille = newListe.Count;
            taille--;

            dataGridView1.Rows.Add(new object[]
                {
                    newListe[taille]["titre"],newListe[taille]["note"], DeleteNote.Text = newListe[taille]["idNote"]

                });

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listeClasseProf listeClasseProf = new listeClasseProf();
            listeClasseProf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detailsClasseProf detailsClasseProf = new detailsClasseProf();
            detailsClasseProf.Show();
            this.Hide(); 
        }
    }
}
