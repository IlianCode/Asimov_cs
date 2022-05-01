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
    public partial class ajtProfProviseur : Form
    {
        Methodes m = new Methodes();
        
        public ajtProfProviseur()
        {
            InitializeComponent();
        }

       

        private void ajtProfProviseur_Load(object sender, EventArgs e)
        {
            dynamic listeMatiere = m.getListeMatiere();

            for (int i = 0; i < listeMatiere.Count; i++)
            {
                comboBox1.Items.Add(new ComboBoxItem(listeMatiere[i]["nom"], listeMatiere[i]["idMatiere"]));
            }
            
        }

        private void buttonCreerEleve_Click(object sender, EventArgs e)
        {
            string nomProf = textBoxNomProf.Text;
            string prenomProf = textBoxPrenomProf.Text;
            string mdpProf = textBoxMdpProf.Text;
            string idMatiere = ((ComboBoxItem)comboBox1.SelectedItem).HiddenValue.ToString();
            string pseudoProf = nomProf + "." + prenomProf;

            //creation d'un prof avec l'api
            string url = "http://localhost:3001/asimov/api/Ajout_Nouveau_Prof/"+nomProf+ "/"+prenomProf+ "/"+idMatiere+ "/"+pseudoProf+ "/"+mdpProf;
            String json = new WebClient().DownloadString(url);
            this.Close();
        }

        
    }
    //creation d'une nouvelle classe afin d'ajouter a chaque element de la combo box une valeur a afficher
    //ainsi qu'une valeur cachée (son id dans la db) a renvoyer au serveur 
    public class ComboBoxItem
    {
        dynamic displayValue;
        dynamic hiddenValue;

        // Constructeur
        public ComboBoxItem(dynamic d, dynamic h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        // Accesseur
        public dynamic HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }

        // Override de la fonction  ToString 
        public override string ToString()
        {
            return displayValue;
        }
    }
}
