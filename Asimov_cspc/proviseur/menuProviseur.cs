using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asimov_cspc.proviseur.listeClasse;
using Asimov_cspc.proviseur.listeEleves;

namespace Asimov_cspc
{
    public partial class menuProviseur : Form
    {
        public menuProviseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //redirige vers le form listeMatiereProviseur
            listeMatiereProviseur listeMatiereProviseur = new listeMatiereProviseur();
            listeMatiereProviseur.Show();
            this.Hide();
        }

        private void menuProviseur_Load(object sender, EventArgs e)
        {
            string nom = Global.userInfo[0]["nom"].ToString();
            
            string prenom = Global.userInfo[0]["prenom"].ToString();
            label1.Text = "Bonjour " + nom.ToUpper() + " " + prenom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeProfProviseur listeProfProviseur = new listeProfProviseur();
            listeProfProviseur.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeNotesProviseur  listeNotesProviseur = new listeNotesProviseur();
            listeNotesProviseur.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listeClassesProviseur listeClassesProviseur = new listeClassesProviseur();
            listeClassesProviseur.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listeElevesProviseur listeElevesProviseur = new listeElevesProviseur();
            listeElevesProviseur.Show();
            this.Hide();
        }
    }
}
