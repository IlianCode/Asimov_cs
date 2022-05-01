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
    public partial class modifEleveProviseur : Form
    {
        Methodes m = new Methodes();
        public static string nom;
        public static string prenom;

        public static string idd;
        public static string iddClasse;
        public modifEleveProviseur(string id, string nom, string prenom, string idClasse)
        {
            InitializeComponent();
            textBoxNomEleve.Text = nom;
            textBoxPrenomEleve.Text = prenom;
            idd = id;
            iddClasse = idClasse;
        }

        private void modifEleveProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeClasse = m.getListeClasse();

            for (int i = 0; i < listeClasse.Count; i++)
            {
                comboBox1.Items.Add(new ComboBoxItem(listeClasse[i]["nom"], listeClasse[i]["idClasse"]));
            }
        }

        private void buttonModifProf_Click(object sender, EventArgs e)
        {
            string newNomEleve = textBoxNomEleve.Text;
            string newPrenomEleve = textBoxPrenomEleve.Text;
            string newClasse = ((ComboBoxItem)comboBox1.SelectedItem).HiddenValue.ToString();
            string pseudo = newNomEleve + "." + newPrenomEleve;
            m.modifEleve(idd,pseudo, newNomEleve, newPrenomEleve, newClasse);
            this.Close();
        }
    }
}
