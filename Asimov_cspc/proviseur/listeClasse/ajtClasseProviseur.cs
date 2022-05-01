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
    public partial class ajtClasseProviseur : Form
    {
        Methodes m = new Methodes();
        public ajtClasseProviseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newName = textBoxNomClasse.Text;
            m.addClasse(newName);
            this.Close();
        }
    }
}
