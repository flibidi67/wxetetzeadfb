using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG67.Bamboue.Utilities;
using System.Configuration;
using System.Data;

namespace CG67.Bamboue.AccesDonnees
{
    public class DonneesInstallation
    {
        ConnectionStringSettings connec = new ConnectionStringSettings("bamboue", ConfigurationManager.ConnectionStrings["bamboueConnectionString"].ConnectionString);

        /// <summary>
        /// Fonction permettant d'avoir l'id ainsi que le nom des installations
        /// </summary>
        /// <returns>DataSet contenant l'id et le nom des installations</returns>
        public DataSet GetToutesInstallations()
        {
            String query = "SELECT IdInstallation, Nom FROM Installation";
            DataSet ds = Utilities.Utilitaire.BuildDataSet(query, connec);
            return ds;
        }
    }
}
