using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;


namespace CG67.Bamboue.AccesDonnees
{
    public class DonneeChamp
    {
        ConnectionStringSettings connec = new ConnectionStringSettings("bamboue", ConfigurationManager.ConnectionStrings["bamboueConnectionString"].ConnectionString);

        /// <summary>
        /// Fonction permettant de trouver un champs en fonction de son installation
        /// </summary>
        /// <param name="id">id de l'installation</param>
        /// <returns>DataSet contenant les informations du champs</returns>
        public DataSet GetChampParIdInstallation(int id)
        {
            String query = "SELECT * FROM Champ c, Champ_Install i WHERE c.IdChamp = i.IdChamp AND i.IdInstallation = " + id.ToString();
            DataSet ds = Utilities.Utilitaire.BuildDataSet(query, connec);
            return ds;
        }

        /// <summary>
        /// Fonction permettant de trouver un champs en fonction de son nom
        /// </summary>
        /// <param name="nom"> nom du champs</param>
        /// <returns>DataSet contenant les informations du champs</returns>
        public DataSet GetChampParNom(String nom)
        {
            String query = "SELECT * FROM Champ WHERE Nom = " + nom;
            DataSet ds = Utilities.Utilitaire.BuildDataSet(query, connec);
            return ds;
        }

        /// <summary>
        /// Fonction permettant de mettre a jour un champs
        /// </summary>
        /// <param name="requete">A REVOIR</param>
        public void UpdateChamp(String requete)
        {
            Utilities.Utilitaire.UpdateBase(requete, connec);
        }
    }
}
