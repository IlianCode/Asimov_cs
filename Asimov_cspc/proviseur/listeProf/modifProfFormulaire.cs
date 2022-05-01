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
    public partial class modifProfFormulaire : Form
    {
        Methodes m = new Methodes();
        public static string nom;
        public static string prenom;

        public static string idd;
        public modifProfFormulaire(string nom, string prenom, string id )
        {
            InitializeComponent();
            textBoxNomProf.Text = nom;
            textBoxPrenomProf.Text = prenom;
            idd = id;
        }

        private void modifProfFormulaire_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifProf_Click(object sender, EventArgs e)
        {
            string newNomProf = textBoxNomProf.Text;
            string newPrenomProf = textBoxPrenomProf.Text;
            string pseudo = newNomProf + "." + newPrenomProf;
            m.modifProfesseur(idd, pseudo, newNomProf, newPrenomProf);
            this.Close();
        }
    }
}
