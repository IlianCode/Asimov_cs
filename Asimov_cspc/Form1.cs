using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;
using Asimov_cspc.eleve;


namespace Asimov_cspc
{
    
    public partial class Form1 : Form
    {
        Methodes m = new Methodes();

        public Form1()
        {
            InitializeComponent();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            m.test();

            String stateTableApi;
            String txtBoxPseudo = textBoxPseudo.Text;
            String txtBoxPwd = textBoxPwd.Text;

            if(radioButtonEleve.Checked == true)
            {
                stateTableApi = "1";
            }
            else
            {
                stateTableApi = "0";
            }
            string url = "http://localhost:3001/Asimov/api/Authentification/" + stateTableApi + "/" + txtBoxPseudo + "/" + txtBoxPwd;
            MessageBox.Show(url);
            String json = new WebClient().DownloadString(url);
            
            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);

            //var articles = data["nom"];
            //var author = articles.Value<string>();
            //MessageBox.Show(data[0]["sa_nom"].ToString());
            //MessageBox.Show(data.Length().ToString());

            if (data != null && radioButtonProf.Checked == true)
            {
                Global.userInfo = data;
                if (Global.userInfo[0]["Proviseur"].ToString() == "1")
                {
                    //renvoie au form menuProviseur
                    menuProviseur menuProviseur = new menuProviseur();
                    menuProviseur.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(Global.userInfo.ToString());

                    listeClasseProf listeClasseProf = new listeClasseProf();
                    listeClasseProf.Show();
                    this.Hide();
                }


            } else if (data != null && radioButtonEleve.Checked == true)
            {
                Global.userInfo = data;

                listeNoteEleve listeNoteEleve = new listeNoteEleve();
                listeNoteEleve.Show();
                this.Hide();
            }
            else if (Global.data != null)
            {
                MessageBox.Show("Vous n'avez pas coché la bonne case");
            }
            else
            {
                MessageBox.Show("Erreur de pseudo ou de mdp");
            }

            MessageBox.Show(Global.userInfo.ToString());
        }

        
    }
    class Global
    {
        public static dynamic data; 
        public static Newtonsoft.Json.Linq.JArray userInfo;
        public static string lastClassChose;
        public static string lastEleveChose;
    }
}
