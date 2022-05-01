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
    public partial class listeClasseProf : Form
    {
        public listeClasseProf()
        {
            InitializeComponent();


        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void listeClasseProf_Load(object sender, EventArgs e)
        {
            /*DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(jsonString, (typeof(DataTable)));
            dataGridView.DataSource = dataTable;*/

            string url = "http://localhost:3001/asimov/api/Classes/" + Global.userInfo[0]["idProf"];
            String json = new WebClient().DownloadString(url);

            dynamic listeClasse = JsonConvert.DeserializeObject<dynamic>(json);

           
            for (int i = 0; i < listeClasse.Count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    listeClasse[i]["nom"],DetailsClasse.Text= listeClasse[i]["idClasse"]

                });
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Global.userInfo.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.lastClassChose = dataGridView1.CurrentCell.Value.ToString();
            detailsClasseProf detailsClasseProf = new detailsClasseProf();
            detailsClasseProf.Show();
            this.Hide();


        }
    }
    
}
