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
    public partial class detailsClasseProf : Form
    {
        public detailsClasseProf()
        {
            InitializeComponent();
        }
        //creation de la fonction getListeEleve recuperant la liste des eleve d'une classe
        public dynamic getListeEleve()
        {
            string url = "http://localhost:3001/asimov/api/Eleves_Classe/" + Global.lastClassChose;

            String json = new WebClient().DownloadString(url);

            dynamic listeEleve = JsonConvert.DeserializeObject<dynamic>(json);
            return listeEleve;
        }
        
        private void detailsClasseProf_Load(object sender, EventArgs e)
        {
            dynamic listeEleve = getListeEleve();
           
            if(listeEleve != null)
            {
                
                for (int i = 0; i < listeEleve.Count; i++)
                {
                dataGridView1.Rows.Add(new object[]
                {
                listeEleve[i]["nom"],listeEleve[i]["prenom"],VoirNotesEleve.Text= listeEleve[i]["idEleve"]});
                }
            }
          
        }
        //permet de revenir a lecran de listage des classes
        private void button1_Click(object sender, EventArgs e)
        {
            listeClasseProf listeClasseProf = new listeClasseProf();
            listeClasseProf.Show();
            this.Hide();
        }
        //renvoie vers la liste des notes d'un eleve en fonction du bouton cliqué
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.lastEleveChose = dataGridView1.CurrentCell.Value.ToString();
            listeNotesEleveMatiere  listeNotesEleveMatiere = new listeNotesEleveMatiere();
            listeNotesEleveMatiere.Show();
            this.Hide();
        }
        //permet de se déconnecter 
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        //permet de créer un nouvel eleve
        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            if (Global.userInfo[0]["Referent"].ToString() =="1")
            {
                String txtBoxNomEleve = textBoxNomEleve.Text;
                String txtBoxPrenomEleve = textBoxPrenomEleve.Text;
                String txtBoxMdpEleve = textBoxMdpEleve.Text;
                String pseudoEleve = txtBoxNomEleve + "." +txtBoxPrenomEleve;

                string url = "http://localhost:3001/asimov/api/Ajout_Nouvel_Eleve/" + pseudoEleve + "/" + txtBoxMdpEleve + "/" + txtBoxNomEleve + "/" + txtBoxPrenomEleve + "/" + Global.lastClassChose;
                String json = new WebClient().DownloadString(url);


                dynamic newListe = getListeEleve();
                int taille = newListe.Count;
                taille--;

                dataGridView1.Rows.Add(new object[]
                    {
                    newListe[taille]["nom"],newListe[taille]["prenom"],VoirNotesEleve.Text= newListe[taille]["idEleve"]

                    });
            }
            else
            {
                MessageBox.Show("Cette fonction est réservée au professeur référent!");
            }
            

        }
    }
}
