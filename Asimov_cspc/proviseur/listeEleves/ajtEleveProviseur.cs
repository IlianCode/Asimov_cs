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
    public partial class ajtEleveProviseur : Form
    {
        Methodes m = new Methodes();
        
        public ajtEleveProviseur()
        {
            InitializeComponent();
        }

        private void ajtEleveProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeClasse = m.getListeClasse();

            for (int i = 0; i < listeClasse.Count; i++)
            {
                comboBox1.Items.Add(new ComboBoxItem(listeClasse[i]["nom"], listeClasse[i]["idClasse"]));
            }
        }

        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            string nomEleve = textBoxNomEleve.Text;
            string prenomEleve = textBoxPrenomEleve.Text;
            string mdpEleve = textBoxMdpEleve.Text;
            string idClasse = ((ComboBoxItem)comboBox1.SelectedItem).HiddenValue.ToString();
            string pseudoEleve = nomEleve + "." + prenomEleve;

            //creation d'un prof avec l'api
            m.addEleve(pseudoEleve, mdpEleve, nomEleve, prenomEleve, idClasse);
            this.Close();
        }
    }
}
