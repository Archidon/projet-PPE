using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicielCompta.Donnees
{
    class DAO
    {
        public List<utilisateur> utilisateurQuery(List<utilisateur> lesUtilisateurs, string saisie)
        {
            using (var model = new Model1())
            {
                foreach (utilisateur lUtilisateur in model.utilisateurs)
                {
                    if(lUtilisateur.nom == saisie)
                    {
                        lesUtilisateurs.Add(lUtilisateur);
                    }
                }
            }

            return lesUtilisateurs;
        }

        public List<string> initListInfosClient()
        {
            using (var model = new Model1())
            {
                utilisateur actif = new utilisateur
                {
                    
                };

                model.joueurs.Add(actif);
                model.SaveChanges();
            }
        }
    }
}
