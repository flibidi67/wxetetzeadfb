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
    class DonneesInstallation
    {
        ConnectionStringSettings connec = new ConnectionStringSettings("bamboue", ConfigurationManager.ConnectionStrings["bamboueConnectionString"].ConnectionString);

        public DataSet GetToutesInstallations()
        {
            String query = "SELECT Nom FROM Installation";
            DataSet ds = Utilities.Utilitaire.BuildDataSet(query, connec);
            return ds;
        }
    }
}
