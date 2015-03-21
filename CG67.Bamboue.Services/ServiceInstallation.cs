using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CG67.Bamboue.Domaine;
using CG67.Bamboue.AccesDonnees;

namespace CG67.Bamboue.Services
{
    class ServiceInstallation
    {

        /// <summary>
        /// Fonction retournant la liste des installations
        /// </summary>
        /// <returns>Liste des intallations</returns>
        public List<Installation> GetInstallations()
        {
            #region Variables
            List<Installation> listeInstallations = new List<Installation>();
            Installation installation;
            DataSet ds = new DataSet();
            DonneesInstallation donneesInstallation = new DonneesInstallation();
            #endregion

            ds = donneesInstallation.GetToutesInstallations();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //Ajout des valeurs pour le magasin
                installation = new Installation();
                installation.IdInstallation = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                installation.Nom = ds.Tables[0].Rows[i][1].ToString();
                listeInstallations.Add(installation);
            }

            return listeInstallations;
        }
    }
}
