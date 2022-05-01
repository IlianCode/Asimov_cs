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
    public partial class modifNoteFormulaire : Form
    {
        Methodes m = new Methodes();
        public static string idd;
        public static string note; 
        public modifNoteFormulaire(string id , string note)
        {
            InitializeComponent();
            idd = id;
            textBoxNote.Text = note;
        }

        private void modifNoteFormulaire_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifProf_Click(object sender, EventArgs e)
        {
            string note = textBoxNote.Text;
           
            //appel de l'api pour modifier la note 
            m.modifNote(idd, note);
            this.Close();
        }
    }
}
