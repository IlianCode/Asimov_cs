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
    public partial class modifFormulaire : Form
    {
        Methodes m = new Methodes();
        public static string nom;
        public static string idd;
        public modifFormulaire(string nom, string id)
        {
            InitializeComponent();

            textBox1.Text = nom;
            idd = id;
        }
        private void modifFormulaire_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newNomMatiere = textBox1.Text;
            m.modifMatiere(idd, newNomMatiere);
            this.Close();
        }
    }
}
