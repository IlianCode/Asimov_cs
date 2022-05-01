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
    public partial class modifClasseProviseur : Form
    {
        Methodes m = new Methodes();

        public static string idd;
        public static string nom;
        public modifClasseProviseur(string id, string nom)
        {
            InitializeComponent();
            textBoxNomClasse.Text = nom;
            idd = id;
        }

        private void buttonModifClasse_Click(object sender, EventArgs e)
        {
            string id = idd;
            string newNom = textBoxNomClasse.Text;
            //Appel de l'api pour modifier le nom de la classe

            m.modifClasse(id, newNom);
            this.Close();
        }

        private void modifClasseProviseur_Load(object sender, EventArgs e)
        {

        }
    }
}
