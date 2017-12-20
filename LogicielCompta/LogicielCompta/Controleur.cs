using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicielCompta.Donnees;

namespace logicielCompta
{
    class Controleur
    {
        public List<utilisateur> getUtilisateurs(string saisie)
        {
            List<utilisateur> listeUtilisateur = new List<utilisateur>();
            DAO dao = new DAO();
            listeUtilisateur = dao.utilisateurQuery(listeUtilisateur, saisie);

            return listeUtilisateur;
        }

        public List<string> getInfosClient()
        {
            List<string> listeInfosClients = new List<string>();




            return listeInfosClients;
        }

        public List<string> getInfosCredits()
        {
            List<string> listeInfosCredits = new List<string>();




            return listeInfosCredits;
        }
    }
}
