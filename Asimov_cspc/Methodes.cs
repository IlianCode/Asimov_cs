using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asimov_cspc
{
    internal class Methodes
    {
        public void test()
        {
            MessageBox.Show("oui");
        }
        //fonction recuperant la liste des matieres en json
        public dynamic getListeMatiere()
        {
            string url = "http://localhost:3001/asimov/api/Matieres";

            String json = new WebClient().DownloadString(url);

            dynamic listeMatiere = JsonConvert.DeserializeObject<dynamic>(json);
            return listeMatiere;
        }

        //fonction créant une nouvelle matiere avec le nom de la matiere en parametre
        public void createMatiere(string txtBoxNomMatiere)
        {
            string url = "http://localhost:3001/asimov/api/Ajout_Nouvelle_Matiere/" + txtBoxNomMatiere;
            String json = new WebClient().DownloadString(url);
        }


        //fonction permettant de supprimer une matiere 
        public void deleteMatiere(string idMatiere)
        {

            string url = "http://localhost:3001/asimov/api/Suppr_Matiere/" + idMatiere;
            String json = new WebClient().DownloadString(url);

        }
        //modification de champs
        public void modifMatiere(string idMatiere,  string nom)
        {
            string url = "http://localhost:3001/asimov/api/Modif_Matiere/" + idMatiere + "/" + nom;
            String json = new WebClient().DownloadString(url);
        }
        //recuperer la liste des professeurs
        public dynamic getListeProfesseur()
        {
            string url = "http://localhost:3001/asimov/api/Professeurs";

            String json = new WebClient().DownloadString(url);

            dynamic listeProfesseur = JsonConvert.DeserializeObject<dynamic>(json);
            return listeProfesseur;
        }
        //supprimer un professeur 
        public void deleteProfesseur(string idProfesseur)
        {
            string url = "http://localhost:3001/asimov/api/Suppr_Prof/" + idProfesseur;
            String json = new WebClient().DownloadString(url);
        }
        //modifier un professeur
        public void modifProfesseur(string idProfesseur,string pseudo, string nom, string prenom)
        {
            string url = "http://localhost:3001/asimov/api/Modif_Prof/" + idProfesseur + "/"+pseudo+"/" + nom + "/" + prenom ;
            String json = new WebClient().DownloadString(url);
        }
        //afficher la liste des notes 
        public dynamic getNotes()
        {
            string url = "http://localhost:3001/asimov/api/Notes/";
            String json = new WebClient().DownloadString(url);
            dynamic listeNotes = JsonConvert.DeserializeObject<dynamic>(json);

            return listeNotes;
        }

        //modifier une note 
        public void modifNote (string id, string note)
        {
            string url = "http://localhost:3001/asimov/api/modif_Notes/"+id+"/"+ note;
            String json = new WebClient().DownloadString(url);
        }
        //supprimer une note 
        public void deleteNote (string id)
        {
            string url = "http://localhost:3001/asimov/api/Suppr_Notes_Matiere/" + id;
            String json = new WebClient().DownloadString(url);
        }
        //afficher tous les eleves 
        public dynamic getEleves()
        {
            string url = "http://localhost:3001/asimov/api/Eleves";
            string json = new WebClient().DownloadString(url);
            dynamic listeNotes = JsonConvert.DeserializeObject<dynamic>(json);
            return listeNotes ;
        }

        //afficher liste classe
        public dynamic getListeClasse()
        {
            string url = "http://localhost:3001/asimov/api/Classes";
            string json = new WebClient().DownloadString(url);
            dynamic listeClasse = JsonConvert.DeserializeObject<dynamic>(json);
            return listeClasse;
        }
        //modifier le nom d'une classe
        public void modifClasse(string id, string nom)
        {
            string url = "http://localhost:3001/asimov/api/Modif_Classe/" + id + "/" + nom;
            String json = new WebClient().DownloadString(url);
        }
        //supprimer une classe
        public void deleteClasse(string idClasse)
        {
            string url = "http://localhost:3001/asimov/api/Suppr_Classe/" + idClasse;
            String json = new WebClient().DownloadString(url);
        }
        //ajouter une nouvelle classe
        public void addClasse(string nom)
        {
            string url = "http://localhost:3001/asimov/api/Ajout_Nouvelle_Classe/" + nom;
            String json = new WebClient().DownloadString(url);

        }
        //afficher tous les eleves par classes
        public dynamic getListeElevesProviseur()
        {
            string url = "http://localhost:3001/asimov/api/ElevesProviseur ";
            string json = new WebClient().DownloadString(url);
            dynamic listeEleves = JsonConvert.DeserializeObject<dynamic>(json);
            return listeEleves;
        }
        //supprimer un eleve 
        public void deleteEleve(string idEleve)
        {
            string url = "http://localhost:3001/asimov/api/Suppr_Eleve/" + idEleve;
            String json = new WebClient().DownloadString(url);
        }
        //modifier un eleve 
        public void modifEleve(string idEleve,string pseudo, string nom, string prenom, string idClasse)
        {
            string url = "http://localhost:3001/asimov/api/Modif_Eleve/" + idEleve + "/"+pseudo+"/"  + nom + "/" + prenom + "/" + idClasse;
            String json = new WebClient().DownloadString(url);
        }
        //ajouter un eleve
        public void addEleve(string pseudo, string mdp, string nom, string prenom, string idClasse)
        {
            string url = "http://localhost:3001/asimov/api/Ajout_Nouvel_Eleve/" + pseudo + "/" + mdp + "/" + nom + "/" + prenom + "/" + idClasse;
            String json = new WebClient().DownloadString(url);
        }
        //============= eleve
        //afficher les notes de l'eleve
        public dynamic getNoteEleve(string idEleve)
        {
            string url = "http://localhost:3001/asimov/api/Notes_Eleve/" + idEleve;
            string json = new WebClient().DownloadString(url);
            dynamic listeNotes = JsonConvert.DeserializeObject<dynamic>(json);
            return listeNotes;
        }
        //afficher les notes de l'eleve par matiere
        public dynamic getNoteEleveMatiere(string idEleve, string idMatiere)
        {
            string url = "http://localhost:3001/asimov/api/Notes_Eleve_Matiere/" + idEleve + "/" + idMatiere;
            string json = new WebClient().DownloadString(url);
            dynamic listeNotes = JsonConvert.DeserializeObject<dynamic>(json);
            return listeNotes;
        }
    }

}
